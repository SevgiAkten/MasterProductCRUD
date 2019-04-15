using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        BAECommerce_PreProd_NewContext db = new BAECommerce_PreProd_NewContext();

        public IActionResult Index()
        {
            return View(db.MasterProduct.Where(x => x.Status != 0).Take(10).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.BrandId = db.Brand.ToList();
            ViewBag.CategoryId = db.Category.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MasterProduct masterProduct)
        {
            ViewBag.BrandId = db.Brand.ToList();
            ViewBag.CategoryId = db.Category.ToList();
            try
            {
                if (ModelState.IsValid)
                {
                    masterProduct.Id = Guid.NewGuid();
                    
                    db.MasterProduct.Add(masterProduct);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View(masterProduct);
        }

        public IActionResult Edit(Guid id)
        {
            var masterProduct = db.MasterProduct.FirstOrDefault(x => x.Id == id);

            ViewBag.BrandId = db.Brand.ToList();
            ViewBag.CategoryId = db.Category.ToList();

            return View(masterProduct);
        }

        [HttpPost]
        public IActionResult Edit(MasterProduct masterProduct)
        {
            MasterProduct mP = db.MasterProduct.Where(x => x.Id == masterProduct.Id).First();

            mP.Name = masterProduct.Name;
            mP.LeadTime = masterProduct.LeadTime;
            mP.ShiploadTime = masterProduct.ShiploadTime;
            mP.MainPrice = masterProduct.MainPrice;
            mP.SalesPrice = masterProduct.SalesPrice;
            mP.Discount = masterProduct.Discount;
            mP.BrandId = masterProduct.BrandId;
            mP.CategoryId = masterProduct.CategoryId;
            mP.AutoId = masterProduct.AutoId;
            mP.CriticalStock = masterProduct.CriticalStock;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid id)
        {
            var masterProduct = db.MasterProduct.FirstOrDefault(x => x.Id == id);
            return View(masterProduct);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var masterProduct = db.MasterProduct.FirstOrDefault(x => x.Id == id);
            masterProduct.Status = 0;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
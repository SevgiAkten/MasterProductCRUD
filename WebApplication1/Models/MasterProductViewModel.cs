using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MasterProductViewModel
    {           
        public List<MasterProduct> masterProducts { get; set; }
        public List<SelectListItem> BrandId { get; } = new List<SelectListItem>
        {

        };
    }
}

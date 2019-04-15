using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ProductExcel
    {
        public Guid Id { get; set; }
        public string TedarikciKodu { get; set; }
        public string Marka { get; set; }
        public string StokKodu { get; set; }
        public string Kategori { get; set; }
        public string UrunAdi { get; set; }
        public string UrunOzellikleri { get; set; }
        public string UrunAciklamasi { get; set; }
        public string IlgiliIlgisiz { get; set; }
        public string UrunKisaAciklamasi { get; set; }
        public string MinumumSiparisAdedi { get; set; }
        public string TeslimSuresi { get; set; }
        public string LojistikTipi { get; set; }
        public string ParakendeSatisFiyati { get; set; }
        public string ListeFiyati { get; set; }
        public string Iskonto1 { get; set; }
        public string Iskonto2 { get; set; }
        public string Iskonto3 { get; set; }
        public string Iskonto4 { get; set; }
        public string Iskonto5 { get; set; }
        public string Birim1Adet { get; set; }
        public string Birim1En { get; set; }
        public string Birim1Boy { get; set; }
        public string Birim1Derinlik { get; set; }
        public string Birim1Agirlik { get; set; }
        public string Birim2Kutu { get; set; }
        public string Birim2Carpani { get; set; }
        public string Birim2En { get; set; }
        public string Birim2Boy { get; set; }
        public string Birim2Derinlik { get; set; }
        public string Birim2Agirlik { get; set; }
        public string Birim3Koli { get; set; }
        public string Birim3Carpani { get; set; }
        public string Birim3En { get; set; }
        public string Birim3Boy { get; set; }
        public string Birim3Derinlik { get; set; }
        public string Birim3Agirlik { get; set; }
        public string BarkodAdet { get; set; }
        public string BarkodKutu { get; set; }
        public string BarkodKoli { get; set; }
        public string FotografUrl { get; set; }
        public string VideoUrl { get; set; }
        public string MarkaLogoUrl { get; set; }
        public string AkcayKodu { get; set; }
        public string Kdv { get; set; }
        public string YeniKod { get; set; }
        public string Messages { get; set; }
        public bool IsIntegrated { get; set; }
        public bool HasError { get; set; }
        public int AttemptCount { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedAdusername { get; set; }
        public int AutoId { get; set; }
    }
}

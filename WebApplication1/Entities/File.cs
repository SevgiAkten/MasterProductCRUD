using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class File
    {
        public File()
        {
            ExcelImportedProduct = new HashSet<ExcelImportedProduct>();
            ProductFile = new HashSet<ProductFile>();
            SliderFile = new HashSet<SliderFile>();
        }

        public Guid Id { get; set; }
        public string Path { get; set; }
        public int Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public bool Processed { get; set; }
        public int Bytes { get; set; }

        public ICollection<ExcelImportedProduct> ExcelImportedProduct { get; set; }
        public ICollection<ProductFile> ProductFile { get; set; }
        public ICollection<SliderFile> SliderFile { get; set; }
    }
}

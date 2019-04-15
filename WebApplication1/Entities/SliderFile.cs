using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class SliderFile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SequenceNumber { get; set; }
        public Guid SliderId { get; set; }
        public Guid FileId { get; set; }
        public Guid? MobileFileId { get; set; }
        public string Url { get; set; }
        public int Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public File File { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class WidgetFile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SequenceNumber { get; set; }
        public Guid WidgetId { get; set; }
        public Guid FileId { get; set; }
        public Guid? MobileFileId { get; set; }
        public string WidgetUrl { get; set; }
        public string WidgetHeader { get; set; }
        public string WidgetContent { get; set; }
        public int Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public Widget Widget { get; set; }
    }
}

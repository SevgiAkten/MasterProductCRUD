﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class EmailTemplate
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public bool? IsDefault { get; set; }
        public Guid TemplateTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Template { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
    }
}

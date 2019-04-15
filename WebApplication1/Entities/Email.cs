using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Email
    {
        public Guid Id { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsBodyHtml { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? Date { get; set; }
        public string Server { get; set; }
        public int? Port { get; set; }
        public string MailAddress { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public bool? EnableSsl { get; set; }
        public bool? UseDefaultCredentials { get; set; }
        public bool? UseAuthentication { get; set; }
        public int Status { get; set; }
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

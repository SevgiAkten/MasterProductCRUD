using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PersonelInformation
    {
        public Guid Id { get; set; }
        public Guid? MasterId { get; set; }
        public Guid? UserId { get; set; }
        public int? MikroId { get; set; }
        public string CurrentCode { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Gender { get; set; }
        public int SpamStatus { get; set; }
        public int? EducationStatus { get; set; }
        public int? WorkingStatus { get; set; }
        public int? MaritalStatus { get; set; }
        public string Interests { get; set; }
        public Guid? SportsTeamId { get; set; }
        public bool? IsAwareOfCampaigns { get; set; }
        public bool? IsAwareOfCampaignsWithSms { get; set; }
        public bool? IsAcceptTheMembershipContract { get; set; }
        public int? PersonalInfoType { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedAdusername { get; set; }
        public int AutoId { get; set; }

        public SportsTeam SportsTeam { get; set; }
    }
}

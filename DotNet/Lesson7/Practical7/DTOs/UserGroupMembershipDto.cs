using System;

namespace Practical7.DTOs
{
    public class UserGroupMembershipDto
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; }
        public int GroupId { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
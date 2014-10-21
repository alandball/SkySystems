using System;

namespace Common.Models
{
    public class Authentication
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int UserIdCreatedBy { get; set; }
        public int? UserIdLastModifiedBy { get; set; }
        public int? UserIdDeletedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User User { get; set; }
    }
}

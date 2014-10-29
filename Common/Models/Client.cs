using System;

namespace Common.Models
{
    public class Client
    {
        public int Id { get; set; }
		public int ClientTypeId { get; set; }

        public string CompanyName { get; set; }
		public string Email { get; set; }
		public string Tel1 { get; set; }
		public string Tel2 { get; set; }
	 
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int UserIdCreatedBy { get; set; }
        public int? UserIdLastModifiedBy { get; set; }
        public int? UserIdDeletedBy { get; set; }
        public bool IsDeleted { get; set; }

       	public virtual ClientType ClientType { get; set; }
    }
}

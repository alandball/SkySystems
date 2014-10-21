using System;

namespace Common.Models
{
    public class Address
    {
        public int Id { get; set; }
		public int ClientId { get; set; }
		public int AddressTypeId { get; set; }
		
		public int PostalCode { get; set; }

        public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }		
		public string AddressLine3 { get; set; }
		public string City { get; set; }
		public string Country { get; set; }		    
	 
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int UserIdCreatedBy { get; set; }
        public int? UserIdLastModifiedBy { get; set; }
        public int? UserIdDeletedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Client Client { get; set; }
		public virtual AddressType AddressType { get; set; }
    }
}

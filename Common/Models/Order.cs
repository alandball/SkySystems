using System;

namespace Common.Models
{
    public class Order
    {
        public int Id { get; set; }
		public int ClientId { get; set; }
		public int AddressId { get; set; }
        public int BranchId { get; set; }
        public int StockLogId { get; set; }

        public string GoogleMapLink { get; set; }

        public DateTime DateToBeDelivered { get; set; }
		public DateTime? DateDelivered { get; set; }
		
		public bool Status { get; set; }		    
	 
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int UserIdCreatedBy { get; set; }
        public int? UserIdLastModifiedBy { get; set; }
        public int? UserIdDeletedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Client Client { get; set; }
		public virtual Address Address { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual StockLog StockLog { get; set; }
    }
}

using System;

namespace Common.Models
{
    public class StockLog
    {
        public int Id { get; set; }
        public int BranchId { get; set; }

        public double InOut { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? DateDeleted { get; set; }

        public int UserIdCreatedBy { get; set; }
        public int? UserIdLastModifiedBy { get; set; }
        public int? UserIdDeletedBy { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
    }
}

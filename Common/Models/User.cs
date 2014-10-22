using System;

namespace Common.Models
{
    public class User
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int UserTypeId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public DateTime? Birthdate { get; set; }
        public string HomeAddress1 { get; set; }
        public string HomeAddress2 { get; set; }
        public string HomeAddress3 { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string PostalAddressPostalCode { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string NationalId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int UserIdCreatedBy { get; set; }
        public int? UserIdLastModifiedBy { get; set; }
        public int? UserIdDeletedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual UserType UserType { get; set; }
    }
}

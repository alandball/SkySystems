using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Common.Models;

namespace UI.ViewModels
{
    public class ClientIndexViewModel
    {
        public List<Client> Clients { get; set; }

        public int Id { get; set; }
        public int UserId { get; set; }

        [Required, Display(Name = "Name")]
        public string CompanyName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Contact 1")]
        public string Tel1 { get; set; }

        [Display(Name = "Contact 2")]
        public string Tel2 { get; set; }

        [Display(Name = "Type of client")]
        public int ClientTypeId { get; set; }

        public List<ClientType> ClientTypes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Common.Models;

namespace UI.ViewModels
{
    public class ClientCreateUpdateViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required, Display(Name = "Name")]
        public string CompanyName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Contact 1")]
        public string Tel1 { get; set; }

        [Display(Name = "Contact 2")]
        public string Tel2 { get; set; }

        public int ClientTypeId { get; set; }
        public List<ClientType> ClientTypes { get; set; }
    }
}
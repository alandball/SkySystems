using System.ComponentModel.DataAnnotations;

namespace UI.ViewModels
{
    public class AuthenticationCreateUpdateViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

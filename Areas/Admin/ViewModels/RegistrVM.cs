using System.ComponentModel.DataAnnotations;

namespace Landab202.Areas.Admin.ViewModels
{
    public class RegistrVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare (nameof(Password))]
        public string ConfirmPassword { get; set; }
       
    }
}

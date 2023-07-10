using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ELTE.TodoList.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Felhasználónév")]
        public String Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Jelszó")]
        public String Password { get; set; } = null!;
    }

    public class RegisterViewModel
    {
        [Required]
        [DisplayName("Felhasználónév")]
        public String Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Jelszó")]
        public String Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Jelszó megerősítése")]
        [Compare("Password")]
        public String PasswordAgain { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace TodoWebAppAsp.Net.Model
{
    public class SignupProperty
    {
        [Required]

        public int Id { get; set; }

        [Required]
        [RegularExpression("^[A-Za-z][A-Za-z0-9_]{3,29}$")]
        public string FirstName { get; set; }


        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")]
        public string Password { get; set; }


        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}

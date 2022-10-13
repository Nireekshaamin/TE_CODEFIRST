using System.ComponentModel.DataAnnotations;

namespace TE_CODEFIRST.Models
{
    public class Trainee
    {
        [Key]
        [Required(ErrorMessage ="Id is required")]
        [Display(Name ="ID")]
        public int Tid { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(15, ErrorMessage = "Max length should be 15")]
        [MinLength(3, ErrorMessage = "Min length should be 3")]
        public string tfirstname { get; set; }
        [Display(Name = "Last Name")]
        [Required( ErrorMessage ="Last name is required")]
        [MaxLength(15, ErrorMessage = "Max length should be 15")]
        [MinLength(3, ErrorMessage = "Max length should be 3")]
        public string tlastname { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "email is required")]
        public string email { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Age is required")]
        [Range(23, 100, ErrorMessage = "Age should be more than 23")]
        public int TAge { get; set; }
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DOB { get; set; }
        [Display(Name = "Gender")]
        [RegularExpression("M|F",ErrorMessage ="The gender must be either M or F only")]
        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }
    }
}

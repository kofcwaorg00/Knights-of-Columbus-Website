using System.ComponentModel.DataAnnotations;

namespace Knights_of_Columbus_Website.Models
{
    public class Knights
    {

        [Key]
        [Display(Name = "Member Id:")]
       
        public int? MemberId { get; set; }

        [Display(Name = "First Name:")]
        public string? FirstName { get; set; }

        [Display(Name = "Middle Intial:")]
        public string? MiddleIntial { get; set; }

        [Display(Name = "Sirname:")]
        public string? SirName1 { get; set; }

        [Display(Name = "Sirname:")]
        public string? SirName2 { get; set; }

        [Display(Name = "User Name:")]
        public string? UserName { get; set; }

        [Display(Name = "Password:")]
        public string? Password { get; set; }
        public bool IsAccepted { get; set; }

        [Display(Name = "Street Address:")]
        public string? StreetAddress { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "State:")]
        public string? State { get; set; }

        [Display(Name = "Zipcode:")]
        public string? PostalCode { get; set; }

        [Display(Name = "Phone Number:")]
        public string? PhoneNum { get; set; }

        [Display(Name = "Email Address:")]
        public string? EmailAddress { get; set; }

        [Display(Name = "Marrial Status:")]
        public bool Ismarried { get; set; }

        [Display(Name = "Spouse First Name:")]
        public string? WFirstName { get; set; }

        [Display(Name = "Spouse Middle Intial:")]
        public string? WMiddleIntial { get; set; }

        [Display(Name = "Spouse Last Name:")]
        public string? WSirName { get; set; }
    }
}

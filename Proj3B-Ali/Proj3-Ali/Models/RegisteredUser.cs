using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Proj3_Ali.Models
{

//Class declaration
    public class RegisteredUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Loan Term is required
        [Required]
        public string LoanTerm { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //First Name is required
        [Required(ErrorMessage = "This field is required.")]
        //First Name only accepts alphabetical input
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Alphabetical characters only.")]
        [Display(Name= "First Name")]
        public string FirstName { get; set; }
 //--------------------------------------------------------------------------------------------------------------//
        //Last Name is required
        [Required(ErrorMessage = "This field is required.")]
        //Only accepts alaphetical input
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Alphabetical characters only.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Zip Code is required
        [Required(ErrorMessage = "This field is required.")]
        //Restricted length of input
        [MinLength(5)]
        [MaxLength(5)]
        //Only allows numerical input
        [RegularExpression(@"\d+", ErrorMessage = "Please enter a 5-digit zip code.")]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Email is required
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Phone Number is required
        [Required(ErrorMessage = "This field is required.")]
        //Restricted length of input
        [MinLength(10)]
        [MaxLength(10)]
        //Only allows numerical input
        [RegularExpression("^[0-9]*$",ErrorMessage ="Please enter a 10-digit phone number without dashes.")]
        [Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Yearly Income is required
        [Required(ErrorMessage = "This field is required.")]
        //Value entered must be between this range
        [Range(1,1000000,ErrorMessage ="Please enter a value between 1 to 1000000")]
        [Display(Name = "Yearly Income")]
        public double YearlyIncome { get; set; }
        //--------------------------------------------------------------------------------------------------------------//
        //Credit Check consent is optional
        [Display(Name = "Credit Check")]
        public bool CreditCheck { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Selection of primary contact method is required
        [Required(ErrorMessage = "Please select a value.")]
        [Display(Name = "Primary Contact")]
        public string PrimaryContact { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Username creation is required
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Username")]
        public String Username { get; set; }
//--------------------------------------------------------------------------------------------------------------//
        //Password creation is required
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Password")]
        public String Password { get; set; }
        //--------------------------------------------------------------------------------------------------------------//
        //Date and time of registration
        public DateTime RegistrationDate { get; set; }
        //--------------------------------------------------------------------------------------------------------------//
        //Password confirmation is required
        //Compare Password field to PasswordConfirm field to validate
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again!")]
        //database will ignore the password compare property/value
        [NotMapped]
        //[Display(Name = "Password Confirm")]
        public String PasswordConfirm { get; set; }
    }

}
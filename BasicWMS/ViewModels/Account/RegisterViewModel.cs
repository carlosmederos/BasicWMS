using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace BasicWMS.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("Password", ErrorMessage = "Password must be equal")]
        [JsonProperty(PropertyName = "confirmPassword")]
        public string ConfirmPassword { get; set; }

    }
}
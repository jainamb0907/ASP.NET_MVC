using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace Practical_15.Models
{

    public class Login : IValidatableObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Index("userName", Order = 1, IsUnique = true)]
        [DisplayName("User Name")]

        public string userName { get; set; }

        [Required]
        [DisplayName("Password")]
        public string password { get; set; }




        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            AuthenticationDB db = new AuthenticationDB();
            List<ValidationResult> validationResult = new List<ValidationResult>();
            var validateName = db.login.FirstOrDefault(x => x.userName == userName);
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            bool validatePassword = Regex.IsMatch(password, pattern); ;
            if (validateName != null)
            {
                ValidationResult errorMessage = new ValidationResult
                ("User name already exists.", new[] { "userName" });
                validationResult.Add(errorMessage);
            }
            //if (validatePassword == false)
            //{
            //    ValidationResult errorMessage = new ValidationResult
            //     ("Invalid password! Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", new[] { "" });
            //    validationResult.Add(errorMessage);
            //}

            return validationResult;
        }
    }
}
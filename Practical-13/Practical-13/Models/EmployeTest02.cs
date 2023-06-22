using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practical_13.Models
{
    [Table("user")]
    public class EmployeTest02
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]

        public string FirstName { get; set; }
        [MaxLength(50)]

        public string MiddleName { get; set; }

        [Required]

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [MaxLength(10)]
        public string MobileNumber { get; set; }
        [MaxLength(100)]

        public string Address { get; set; }

        [Required]
        public decimal salary { get; set; }

        [DisplayName("Designation")]
        [ForeignKey("Designation")]
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }
    }
}
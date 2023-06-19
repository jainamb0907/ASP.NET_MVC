using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Practical_13.Models
{

        public class EmployeeDB : DbContext
        {
            public EmployeeDB()
           : base("EmployeeDB")
            {

            }
            public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeTest02> Emp { get; set; }
        public DbSet<Designation> Designations { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Practical_15.Models
{
    public class AuthenticationDB : DbContext
    {
        public AuthenticationDB()
       : base("AuthenticationDB")
        {

        }

        public DbSet<Login> login { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebService
{
    public class ConnectDB : DbContext
    {
        public ConnectDB() : base("Connect")
        {

        }

        public DbSet<Student> Students { get; set; }
        //public DbSet<AllInfoStudent> AllInfoStudents { get; set; }
    }
}
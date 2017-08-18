using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext():base("EmployeeDbContext")
        {
                
        }
        public DbSet<Employee> employees { get; set; }
    }
}
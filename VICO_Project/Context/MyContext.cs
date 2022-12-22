using Microsoft.EntityFrameworkCore;
using VICO_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }


        // Mengatur connection string (done)
        // menambahkan model untuk diolah dan / atau migrasi (done)

        /* 
         Code first
         */


        public DbSet<Cuti> Cutis { get; set; }
        //public DbSet<Status> Status { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyUni.Models;

    public class MyUniContextDb : IdentityDbContext
    {
        public MyUniContextDb (DbContextOptions<MyUniContextDb> options)
            : base(options)
        {
        }

        public DbSet<MyUni.Models.Student> Student { get; set; } = default!;

        public DbSet<MyUni.Models.Enrollment> Enrollment { get; set; } = default!;

        public DbSet<MyUni.Models.Course> Course { get; set; } = default!;
    }

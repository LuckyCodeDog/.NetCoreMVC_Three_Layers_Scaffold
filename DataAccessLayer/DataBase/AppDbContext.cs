using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataBase
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }

        DbSet<Score> Scores { get; set; }
    }
}

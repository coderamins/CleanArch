using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UnivercityDBContext : DbContext
    {
        protected UnivercityDBContext(DbContextOptions options):base(options)
        {            
        }

        public DbSet<Course> Courses{get;set;}
    }
}
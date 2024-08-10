using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blogapi.Models;


namespace Blogapi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options):base(options)
        {
             
        }
        public DbSet<PostModel> Postmodel { set; get; }
    }
}
// dotnet add package Microsoft.EntityFrameworkCore
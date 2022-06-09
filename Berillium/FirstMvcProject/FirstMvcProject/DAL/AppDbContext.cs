using FirstMvcProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}

       public  DbSet<BigSlide> BigSlides { set; get; }
       public DbSet<SmallSlide> SmallSlides { set; get; }
       public DbSet<News> MyNews { set; get; }
       public DbSet<Testimonials> Testimon { set; get; }

       public DbSet<IconRow> IconsRow { set; get; }
    }
}

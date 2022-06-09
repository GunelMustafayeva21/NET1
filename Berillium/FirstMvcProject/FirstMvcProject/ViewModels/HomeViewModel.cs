using FirstMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.ViewModels
{
    public class HomeViewModel
    {
       public List<BigSlide> bigSlides { set; get; }
       public List<SmallSlide> smallSlides { set; get; }
       public List<News> myNews { set; get; }

       public List<Testimonials> testimon { set; get; }
       
       public List<IconRow> iconsRow { set; get; }
    }
}

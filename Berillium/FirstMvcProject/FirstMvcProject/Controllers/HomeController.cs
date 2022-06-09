
using FirstMvcProject.DAL;
using FirstMvcProject.Models;
using FirstMvcProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;

        public HomeController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                bigSlides = db.BigSlides.ToList(),
                smallSlides = db.SmallSlides.ToList(),
                myNews=db.MyNews.ToList(),
                testimon=db.Testimon.ToList(),
                iconsRow=db.IconsRow.ToList(),
            };
            return View(hvm);


        }

        
    }
}

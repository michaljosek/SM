using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Builder;
using SM.Infrastructure.Settings;
using Autofac;
using SM.Core.Repositories;
using SM.Infrastructure.EF;
using SM.Core.Paging;

namespace SM.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IB07_zgloRepository _repo;

        public HomeController(IB07_zgloRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}

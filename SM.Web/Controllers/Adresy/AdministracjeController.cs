using Microsoft.AspNetCore.Mvc;
using SM.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Web.Controllers.Adresy
{
    public class AdministracjeController : Controller
    {
        private readonly IAdresService _administracjeService;

        public AdministracjeController(IAdresService administracjeService)
        {
            _administracjeService = administracjeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 10)
        {
            var b07_zgloList = await _administracjeService.BrowseAdmAsync(pageIndex, pageSize);

            return View(b07_zgloList);
        }
    }
}

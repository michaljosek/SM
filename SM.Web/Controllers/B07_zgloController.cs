using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SM.Infrastructure.DTO;
using SM.Infrastructure.Services;
using SM.Web.ViewModels;
using SM.Web.ViewModels.B07_zgloViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Web.Controllers
{
    public class B07_zgloController : Controller
    {
        private readonly IB07_zgloService _b07_zgloService;
        private readonly IAdresService _administracjeService;

        public B07_zgloController(IB07_zgloService b07_zgloService, IAdresService administracjeService)
        {
            _b07_zgloService = b07_zgloService;
            _administracjeService = administracjeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sortOrder = "numer_zglo", bool orderAsc = true, int pageIndex = 1, int pageSize = 10)
        {
            var b07_zgloList = await _b07_zgloService.BrowseAsync(sortOrder, orderAsc, pageIndex, pageSize);

            return View(b07_zgloList);
        }

        public async Task<IActionResult> Create()
        {
            if(ModelState.IsValid)
            {
                var noweIdB07_zglo = await _b07_zgloService.AddAsync();

                return RedirectToAction("Edit", new { id = noweIdB07_zglo });
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if(ModelState.IsValid)
            {
                var b07_zgloObj = await _b07_zgloService.GetZgloAsync(id);
                var administracje = await _administracjeService.GetAllAdmAsync();
                var branze = await _administracjeService.GetAllBranzeAsync();
                var pracownicy = await _administracjeService.GetAllPracownicyAsync();
                var vm = new B07_zgloEditViewModel
                {
                    B07_ZgloDTO = b07_zgloObj,
                    Administracje = new SelectList(administracje, "id_admi", "nazwa"),
                    Branze = new SelectList(branze, "nr_branzy", "nazwa_bran"),
                    Pracownicy = new SelectList(pracownicy, "nr_osoby", "nazwisko")
                };

                return View(vm);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(B07_zgloEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var zgloszenie = vm.B07_ZgloDTO;
                await _b07_zgloService.UpdateAsync(zgloszenie, zgloszenie.B07_zgloId);

                return RedirectToAction("Index");
            }

            var administracje = await _administracjeService.GetAllAdmAsync();
            var branze = await _administracjeService.GetAllBranzeAsync();
            var pracownicy = await _administracjeService.GetAllPracownicyAsync();
            vm.Administracje = new SelectList(administracje, "id_admi", "nazwa");
            vm.Branze = new SelectList(branze, "nr_branzy", "nazwa_bran");
            vm.Pracownicy = new SelectList(pracownicy, "nr_osoby", "nazwisko");

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var b07_zgloObj = await _b07_zgloService.GetZgloAsync(id);

            return PartialView(b07_zgloObj);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _b07_zgloService.RemoveAsync(id);

            return Json(Url.Action("Index"));
        }

        //pomocnicze
        public async Task<IActionResult> GetBudynki()
        {
            var budynkiDb = await _administracjeService.GetAllBudAsync();

            return Json(budynkiDb);
        }

        public async Task<IActionResult> GetKlatki(string budynekId)
        {
            var klatkiDb = await _administracjeService.GetKlatkiAsync(budynekId);

            return Json(klatkiDb);
        }

        public async Task<IActionResult> GetLokale(string klatkaId, string budynekId)
        {
            var lokaleDb = await _administracjeService.GetLokaleAsync(klatkaId, budynekId);

            return Json(lokaleDb);
        }

        public async Task<IActionResult> UtworzAdresString(string budynekId = "", string klatkaId = "", string lokalId = "")
        {
            var adres = await _administracjeService.CreateStringAddress(budynekId, klatkaId, lokalId);

            return Json(adres);
        }

        public async Task<IActionResult> FindAddressFromString(string adres)
        {
            var wynik = await _administracjeService.FindAddressFromString(adres);

            return Json(wynik);
        }
    }
}

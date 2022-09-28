using IsBasvuruApp.BLL.Services.IlceService;
using IsBasvuruApp.BLL.Services.ILService;
using IsBasvuruApp.BLL.Services.PersonelService;
using IsBasvuruApp.BLL.ViewModels;
using IsBasvuruApp.CORE.Entities;
using IsBasvuruApp.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IsBasvuruApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonelService personelService;
        private readonly IILService ilService;
        private readonly IILceService ilceService;

        public HomeController(IPersonelService personelService, IILService ilService, IILceService ilceService)
        {
            this.personelService = personelService;
            this.ilService = ilService;
            this.ilceService = ilceService;
        }

        public async Task<IActionResult> Index()
        {
            List<PersonelListVM> vm = await personelService.GetAll();
            return View(vm);
        }

        public async Task<IActionResult> Create()
        {
            List<SelectListItem> itemSelectList = await IlSelectListGetir();
            ViewBag.Iller = itemSelectList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Personel model)
        {
            bool result = await personelService.CreatePersonel(model);
            if (!result)
            {
                List<SelectListItem> itemSelectList = await IlSelectListGetir();
                ViewBag.Iller = itemSelectList;
                ViewBag.Error = "Personel eklenirken hata oluştu";
                return View();
            }

            TempData["Success"] = "Personel Eklendi"; 
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            bool result = await personelService.DeletePersonel(id);
            if (!result) TempData["Error"] = "Personel silinirken hata oluştu.";

            TempData["Success"] = "Personel silindi.";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(long id)
        {
            Personel personel = await personelService.GetPersonelById(id);
            List<SelectListItem> itemSelectList = await IlSelectListGetir();
            ViewBag.Iller = itemSelectList;

            List<SelectListItem> iilceSelects = await IlceSelectListGetir(personel.IlID);
            ViewBag.Ilceler = iilceSelects;

            return View("Create", personel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Personel model)
        {
            bool result = await personelService.UpdatePersonel(model);
            if (!result)
            {
                List<SelectListItem> itemSelectList = await IlSelectListGetir();
                ViewBag.Iller = itemSelectList;
                ViewBag.Error = "Personel güncellenirken hata oluştu";
                return View();
            }

            TempData["Success"] = "Personel Güncellendi";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> IlceleriGetir(long id)
        {
            List<Ilce> ilceler = await ilceService.GetAllBySehir(id);
            return Json(ilceler);
        }

        public async Task<List<SelectListItem>> IlSelectListGetir()
        {
            List<SelectListItem> itemSelectList = new List<SelectListItem>();
            List<Il> iller = await ilService.GetAll();

            itemSelectList.Add(new SelectListItem { Value = "0", Text = "İl Seçiniz" });
            foreach (Il item in iller)
            {
                itemSelectList.Add(new SelectListItem { Value = item.ID.ToString(), Text = item.Adi });
            }

            return itemSelectList;
        }

        public async Task<List<SelectListItem>> IlceSelectListGetir(long sehirId)
        {
            List<SelectListItem> itemSelectList = new List<SelectListItem>();
            List<Ilce> ilceler = await ilceService.GetAllBySehir(sehirId);

            foreach (Ilce item in ilceler)
            {
                itemSelectList.Add(new SelectListItem { Value = item.ID.ToString(), Text = item.Adi });
            }

            return itemSelectList;
        }


    }
}

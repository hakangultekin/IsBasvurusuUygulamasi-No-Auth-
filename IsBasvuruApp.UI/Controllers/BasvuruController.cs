using IsBasvuruApp.BLL.Services.ILService;
using IsBasvuruApp.BLL.Services.PersonelBasvuruService;
using IsBasvuruApp.CORE.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsBasvuruApp.UI.Controllers
{
    public class BasvuruController : Controller
    {
        private readonly IPersonelBasvuruService personelBasvuruService;
        private readonly IILService ilService;

        public BasvuruController(IPersonelBasvuruService personelBasvuruService, IILService ilService)
        {
            this.personelBasvuruService = personelBasvuruService;
            this.ilService = ilService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PersonelBasvurulari(long personelID)
        {
            List<PersonelBasvuru> basvurular = await personelBasvuruService.GetAllByPersonelIdIncludesIller(personelID);
            ViewBag.personelID = personelID;
            return View(basvurular);
        }

        public async Task<IActionResult> Create(long personelID)
        {
            List<SelectListItem> iller = await IlSelectListGetir();
            ViewBag.Iller = iller;
            ViewBag.personelID = personelID;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PersonelBasvuru basvuru)
        {
            bool result = await personelBasvuruService.Create(basvuru);
            if(!result)
            {
                ViewBag.Error = "Başvuru oluşturulurken hata oluştu";
                List<SelectListItem> iller = await IlSelectListGetir();
                ViewBag.Iller = iller;
                return View(basvuru);
            }

            TempData["Success"] = "Başvuru kaydedildi";
            return RedirectToAction("PersonelBasvurulari", "Basvuru", new { personelID = basvuru.PersonelID });
        }

        public async Task<IActionResult> Delete(long basvuruID, long personelID)
        {
            bool result = await personelBasvuruService.Delete(basvuruID);
            if (!result) TempData["Error"] = "Başvuru silinirken hata oluştu";
            TempData["Success"] = "Başvuru Silindi";

            return RedirectToAction("PersonelBasvurulari", "Basvuru",new {personelID = personelID });
        }

        public async Task<IActionResult> Edit(long basvuruID)
        {
            PersonelBasvuru basvuru = await personelBasvuruService.GetById(basvuruID);
            List<SelectListItem> iller = await IlSelectListGetir();
            ViewBag.Iller = iller;

            return View("Create", basvuru);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PersonelBasvuru basvuru)
        {
            bool result = await personelBasvuruService.Update(basvuru);
            if (!result) ViewBag.Error = "Başvuru düzenleme işlemi başarısız.";

            TempData["Success"] = "Başvuru düzenlendi";
            return RedirectToAction("PersonelBasvurulari", "Basvuru", new { personelID = basvuru.PersonelID });
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
    }
}

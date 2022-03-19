using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kutuphane24.Models;

namespace kutuphane24.Controllers
{
    public class TblPersonelsController : Controller
    {
        private readonly KutuphaneDBContext _context;

        public TblPersonelsController(KutuphaneDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TblPersonels.ToListAsync());
        }

        [HttpGet]
        public ActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonelEkle(TblPersonel p)
        {
            if (!ModelState.IsValid)
            {
                return View("PersonelEkle");
            }
            _context.TblPersonels.Add(p);
            _context.SaveChanges();
            return View();
        }

        public ActionResult PersonelSil(int id)
        {
            var personel = _context.TblPersonels.Find(id);
            _context.TblPersonels.Remove(personel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelGetir(int id)
        {
            var ktg = _context.TblPersonels.Find(id);
            return View("PersonelGetir", ktg);
        }

        public ActionResult PersonelGuncelle(TblPersonel p)
        {
            var ktg = _context.TblPersonels.Find(p.PersonelId);
            ktg.Personel = p.Personel;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

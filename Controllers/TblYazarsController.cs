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
    public class TblYazarsController : Controller
    {
        private readonly KutuphaneDBContext _context;

        public TblYazarsController(KutuphaneDBContext context)
        {
            _context = context;
        }

        // GET: TblYazars
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblYazars.ToListAsync());
        }

        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }

        public ActionResult YazarEkle(TblYazar p)
        {
            _context.TblYazars.Add(p);
            _context.SaveChanges();
            return View();
        }

        public ActionResult YazarSil(int id)
        {
            var yazar = _context.TblYazars.Find(id);
            _context.TblYazars.Remove(yazar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarGetir(int id)
        {
            var yzr = _context.TblYazars.Find(id);
            return View("YazarGetir", yzr);
        }

        public ActionResult YazarGuncelle(TblYazar p)
        {
            var yzr = _context.TblYazars.Find(p.YazarId);
            yzr.Ad = p.Ad;
            yzr.Soyad = p.Soyad;
            yzr.Detay = p.Detay;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

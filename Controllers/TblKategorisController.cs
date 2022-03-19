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
    public class TblKategorisController : Controller
    {
        private readonly KutuphaneDBContext _context;

        public TblKategorisController(KutuphaneDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TblKategoris.ToListAsync());
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(TblKategori p)
        {
            _context.TblKategoris.Add(p);
            _context.SaveChanges();
            return View();
        }

        public ActionResult KategoriSil(int id)
        {
            var kategori = _context.TblKategoris.Find(id);
            _context.TblKategoris.Remove(kategori);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var ktg = _context.TblKategoris.Find(id);
            return View("KategoriGetir", ktg);
        }

        public ActionResult KategoriGuncelle(TblKategori p)
        {
            var ktg = _context.TblKategoris.Find(p.KategoriId);
            ktg.KategoriAd = p.KategoriAd;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

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
    public class TblKitapsController : Controller
    {
        private readonly KutuphaneDBContext _context;

        public TblKitapsController(KutuphaneDBContext context)
        {
            _context = context;
        }

        // GET: TblKitaps
        public async Task<IActionResult> Index(string p)
        {
            var kutuphaneDBContext = _context.TblKitaps.Include(t => t.KategoriNavigation).Include(t => t.YazarNavigation);
            return View(await kutuphaneDBContext.ToListAsync());

            //var kutuphaneDBContext = from k in _context.TblKitaps select k;
            //if (!string.IsNullOrEmpty(p))
            //{
            //    kutuphaneDBContext = kutuphaneDBContext.Where(m => m.Ad.Contains(p));
            //}
            //return View(kutuphaneDBContext.ToList());
        }

        [HttpGet]
        public ActionResult KitapEkle()
        {
            List<SelectListItem> deger1 = (from i in _context.TblKategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.KategoriAd,
                                               Value = i.KategoriId.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;


            List<SelectListItem> deger2 = (from i in _context.TblYazars.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.Ad+' '+i.Soyad,
                                               Value = i.YazarId.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger2;
            return View();
        }

        [HttpPost]
        public ActionResult KitapEkle(TblKitap p)
        {
            var ktg = _context.TblKategoris.Where(k => k.KategoriId == p.KategoriNavigation.KategoriId).FirstOrDefault();
            var yzr = _context.TblYazars.Where(y => y.YazarId == p.YazarNavigation.YazarId).FirstOrDefault();
            p.KategoriNavigation = ktg;
            p.YazarNavigation = yzr;
            _context.TblKitaps.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult KitapSil(int id)
        {
            var kitap = _context.TblKitaps.Find(id);
            _context.TblKitaps.Remove(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapGetir(int id)
        {
            var ktp = _context.TblKitaps.Find(id);

            List<SelectListItem> deger1 = (from i in _context.TblKategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.KategoriAd,
                                               Value = i.KategoriId.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            List<SelectListItem> deger2 = (from i in _context.TblYazars.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.Ad + ' ' + i.Soyad,
                                               Value = i.YazarId.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger2;

            return View("KitapGetir", ktp);
        }

        public  ActionResult KitapGuncelle(TblKitap p)
        {
            var kitap = _context.TblKitaps.Find(p.KitapId);
            kitap.Ad = p.Ad;
            kitap.BasimYil = p.BasimYil;
            kitap.Sayfa = p.Sayfa;
            kitap.YayinEvi = p.YayinEvi;

            var ktg = _context.TblKategoris.Where(k => k.KategoriId == p.KategoriNavigation.KategoriId).FirstOrDefault();
            var yzr = _context.TblYazars.Where(k => k.YazarId == p.YazarNavigation.YazarId).FirstOrDefault();
            kitap.Kategori = ktg.KategoriId;
            kitap.Yazar = yzr.YazarId;
            _context.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}

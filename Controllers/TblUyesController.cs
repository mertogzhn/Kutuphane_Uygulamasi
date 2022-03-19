using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kutuphane24.Models;
using PagedList;
using PagedList.Mvc;


namespace kutuphane24.Controllers
{
    public class TblUyesController : Controller
    {
        private readonly KutuphaneDBContext _context;

        public TblUyesController(KutuphaneDBContext context)
        {
            _context = context;
        }

        // GET: TblUyes
        public async Task<IActionResult> Index(int sayfa=1)
        {
            var degerler = _context.TblUyes.ToList();
            return View(degerler);
        }

        public ActionResult UyeEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UyeEkle(TblUye p)
        {
            if (!ModelState.IsValid)
            {
                return View("UyeEkle");
            }
            _context.TblUyes.Add(p);
            _context.SaveChanges();
            return View();
        }

        public ActionResult UyeSil(int id)
        {
            var uye1 = _context.TblUyes.Find(id);
            _context.TblUyes.Remove(uye1);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UyeGetir(int id)
        {
            var uye = _context.TblUyes.Find(id);
            return View("UyeGetir", uye);
        }

        public ActionResult UyeGuncelle(TblUye p)
        {
            var uye = _context.TblUyes.Find(p.UyeId);
            uye.UyeId = p.UyeId;
            uye.Ad = p.Ad;
            uye.Soyad = p.Soyad;
            uye.Mail = p.Mail;
            uye.Okul = p.Okul;
            uye.Sifre = p.Sifre;
            uye.Telefon = p.Telefon;
            uye.KullaniciAdi = p.KullaniciAdi;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

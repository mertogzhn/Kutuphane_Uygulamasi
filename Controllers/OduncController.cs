using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kutuphane24.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace kutuphane24.Controllers
{
    public class OduncController : Controller
    {
        private readonly KutuphaneDBContext _context;

        public OduncController(KutuphaneDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var kutuphaneDBContext = _context.TblHarekets.Include(t => t.KitapNavigation).Include(t => t.UyeNavigation);
            return View(await kutuphaneDBContext.ToListAsync());
        }

        [HttpGet]
        public IActionResult OduncVer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OduncVer(TblHareket p)
        {
            _context.TblHarekets.Add(p);
            _context.SaveChanges();
            return View();
        }

        public async Task<IActionResult> Odunciade(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblHareket = await _context.TblHarekets
                .Include(t => t.KitapNavigation)
                .Include(t => t.UyeNavigation)
                .FirstOrDefaultAsync(m => m.HareketId == id);
            if (tblHareket == null)
            {
                return NotFound();
            }

            return View(tblHareket);
        }

    }
}

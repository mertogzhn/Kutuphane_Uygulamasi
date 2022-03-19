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
    public class TblHareketsController : Controller
    {
        private readonly KutuphaneDBContext _context;

        public TblHareketsController(KutuphaneDBContext context)
        {
            _context = context;
        }

        // GET: TblHarekets
        public async Task<IActionResult> Index()
        {
            var kutuphaneDBContext = _context.TblHarekets.Include(t => t.KitapNavigation).Include(t => t.UyeNavigation);
            return View(await kutuphaneDBContext.ToListAsync());
        }

        // GET: TblHarekets/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: TblHarekets/Create
        public IActionResult HareketEkle()
        {
            //ViewData["Kitap"] = new SelectList(_context.TblKitaps, "KitapId", "KitapId");
            ViewData["Kitap"] = new SelectList(_context.TblKitaps, "Ad", "Ad");
            ViewData["Uye"] = new SelectList(_context.TblUyes, "UyeId", "UyeId");
            ViewData["Personel"] = new SelectList(_context.TblPersonels, "PersonelId", "PersonelId");
            return View();
        }

        // POST: TblHarekets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HareketEkle([Bind("HareketId,Kitap,Uye,Personel,AlısTarih,İadeTarih")] TblHareket tblHareket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblHareket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Kitap"] = new SelectList(_context.TblKitaps, "KitapId", "KitapId", tblHareket.Kitap);
            ViewData["Uye"] = new SelectList(_context.TblUyes, "UyeId", "UyeId", tblHareket.Uye);
            ViewData["Personel"] = new SelectList(_context.TblPersonels, "PersonelId", "PersonelId");
            return View(tblHareket);
        }

        // GET: TblHarekets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblHareket = await _context.TblHarekets.FindAsync(id);
            if (tblHareket == null)
            {
                return NotFound();
            }
            ViewData["Kitap"] = new SelectList(_context.TblKitaps, "KitapId", "KitapId", tblHareket.Kitap);
            ViewData["Uye"] = new SelectList(_context.TblUyes, "UyeId", "UyeId", tblHareket.Uye);
            return View(tblHareket);
        }

        // POST: TblHarekets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HareketId,Kitap,Uye,Personel,AlısTarih,İadeTarih")] TblHareket tblHareket)
        {
            if (id != tblHareket.HareketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblHareket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblHareketExists(tblHareket.HareketId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Kitap"] = new SelectList(_context.TblKitaps, "KitapId", "KitapId", tblHareket.Kitap);
            ViewData["Uye"] = new SelectList(_context.TblUyes, "UyeId", "UyeId", tblHareket.Uye);
            return View(tblHareket);
        }

        // GET: TblHarekets/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: TblHarekets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblHareket = await _context.TblHarekets.FindAsync(id);
            _context.TblHarekets.Remove(tblHareket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblHareketExists(int id)
        {
            return _context.TblHarekets.Any(e => e.HareketId == id);
        }
    }
}

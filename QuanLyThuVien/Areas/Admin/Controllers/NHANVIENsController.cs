using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyThuVien.Models;

namespace QuanLyThuVien.Areas.Admin.Controllers
{
    public class NHANVIENsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Admin/NHANVIENs
        public async Task<ActionResult> Index()
        {
            var nHANVIENs = db.NHANVIENs.Include(n => n.CHINHANH).Include(n => n.LOAINHANVIEN);
            return View(await nHANVIENs.ToListAsync());
        }

        // GET: Admin/NHANVIENs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = await db.NHANVIENs.FindAsync(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // GET: Admin/NHANVIENs/Create
        public ActionResult Create()
        {
            ViewBag.MaCN = new SelectList(db.CHINHANHs, "MaCN", "TenCN");
            ViewBag.MaLoaiNV = new SelectList(db.LOAINHANVIENs, "MaLoaiNV", "TenLoaiNV");
            return View();
        }

        // POST: Admin/NHANVIENs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaNV,HoTenNV,CMND,SDT,DiaChi,Email,HinhAnh,MaCN,MaLoaiNV,UserName,Password")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                db.NHANVIENs.Add(nHANVIEN);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.MaCN = new SelectList(db.CHINHANHs, "MaCN", "TenCN", nHANVIEN.MaCN);
            ViewBag.MaLoaiNV = new SelectList(db.LOAINHANVIENs, "MaLoaiNV", "TenLoaiNV", nHANVIEN.MaLoaiNV);
            return View(nHANVIEN);
        }

        // GET: Admin/NHANVIENs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = await db.NHANVIENs.FindAsync(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaCN = new SelectList(db.CHINHANHs, "MaCN", "TenCN", nHANVIEN.MaCN);
            ViewBag.MaLoaiNV = new SelectList(db.LOAINHANVIENs, "MaLoaiNV", "TenLoaiNV", nHANVIEN.MaLoaiNV);
            return View(nHANVIEN);
        }

        // POST: Admin/NHANVIENs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MaNV,HoTenNV,CMND,SDT,DiaChi,Email,HinhAnh,MaCN,MaLoaiNV,UserName,Password")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nHANVIEN).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.MaCN = new SelectList(db.CHINHANHs, "MaCN", "TenCN", nHANVIEN.MaCN);
            ViewBag.MaLoaiNV = new SelectList(db.LOAINHANVIENs, "MaLoaiNV", "TenLoaiNV", nHANVIEN.MaLoaiNV);
            return View(nHANVIEN);
        }

        // GET: Admin/NHANVIENs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = await db.NHANVIENs.FindAsync(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // POST: Admin/NHANVIENs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NHANVIEN nHANVIEN = await db.NHANVIENs.FindAsync(id);
            db.NHANVIENs.Remove(nHANVIEN);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

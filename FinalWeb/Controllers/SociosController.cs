using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FinalWeb.Context;
using FinalWeb.Models;
using Image = System.Drawing.Image;

namespace FinalWeb.Controllers
{
    public class SociosController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Socios
        public ActionResult Index()
        {
            return View(db.Socios.ToList());
        }

        // GET: Socios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socios socios = db.Socios.Find(id);
            if (socios == null)
            {
                return HttpNotFound();
            }
            return View(socios);
        }

        // GET: Socios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Socios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SociosID,Nombre,Apellido,Foto,Cedula,Direccion,Telefono,Sexo,Edad,Nacimiento,Afiliados,Membresia,LugarTrabajo,DireccionOficina,TelefonoOficina,Estado,FechaIngreso,FechaSalida")] Socios socios)
        {
            HttpPostedFileBase FileBase = Request.Files[0];

            WebImage imagen = new WebImage(FileBase.InputStream);
            socios.Foto = imagen.GetBytes();


            if (ModelState.IsValid)
            {
                db.Socios.Add(socios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(socios);
        }

        // GET: Socios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socios socios = db.Socios.Find(id);
            if (socios == null)
            {
                return HttpNotFound();
            }
            return View(socios);
        }

        // POST: Socios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SociosID,Nombre,Apellido,Cedula,Direccion,Telefono,Sexo,Edad,Nacimiento,Afiliados,Membresia,LugarTrabajo,DireccionOficina,TelefonoOficina,Estado,FechaIngreso,FechaSalida")] Socios socios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socios);
        }

        // GET: Socios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socios socios = db.Socios.Find(id);
            if (socios == null)
            {
                return HttpNotFound();
            }
            return View(socios);
        }

        // POST: Socios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Socios socios = db.Socios.Find(id);
            db.Socios.Remove(socios);
            db.SaveChanges();
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

        public ActionResult buscarImagen(int id)
        {
            Socios socio = db.Socios.Find(id);
            byte[] imagenEnByte = socio.Foto;

            MemoryStream memoria = new MemoryStream(imagenEnByte);
            Image image = Image.FromStream(memoria);

            memoria = new MemoryStream();
            image.Save(memoria, ImageFormat.Jpeg);
            memoria.Position = 0;

            return File(memoria, "image/jpg");
        }
    }
}

using progra6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace progra6.Controllers
{
    public class PersonaSemana4Controller : Controller
    {
        progra6Entities db = new progra6Entities();
        // GET: PersonaSemana4
        public ActionResult Index()
        {
            //progra6Entities db = new progra6Entities();
            var persona = db.Personas.ToList();
            return View(persona);
        }

        public ActionResult Index2()
        {
            progra6Entities db = new progra6Entities();
            var persona2 = db.Personas.ToList();
            return View();
        }

        // GET: PersonaSemana4/Details/5
        public ActionResult Details(int id)
        {
            //LINQ
            Persona myPerson = (from c in db.Personas where id == c.id select c).First();
            return View(myPerson);
        }

        // GET: PersonaSemana4/Create
        public ActionResult Create( )
        {
            
            return View();
        }

        // POST: PersonaSemana4/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Persona myPerson = new Persona();
                myPerson.IDN = collection["IDN"];
                myPerson.nombre = collection["nombre"];
                myPerson.apellido = collection["apellido"];
                myPerson.email = collection["email"];
                myPerson.fechaNacimiento = collection["fechaNacimiento"];
                db.sp_insert_personas(myPerson.IDN, myPerson.nombre, myPerson.apellido, myPerson.email, myPerson.fechaNacimiento);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaSemana4/Edit/5
        public ActionResult Edit(int id)
        {
            //LINQ
            Persona myPerson = (from c in db.Personas where id == c.id select c).First();
            return View(myPerson);
        }

        // POST: PersonaSemana4/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Persona myPerson = new Persona();
                myPerson.IDN = collection["IDN"];
                myPerson.nombre = collection["nombre"];
                myPerson.apellido = collection["apellido"];
                myPerson.email = collection["email"];
                myPerson.fechaNacimiento = collection["fechaNacimiento"];
                db.sp_update_personas(myPerson.IDN, myPerson.nombre, myPerson.apellido, myPerson.email, myPerson.fechaNacimiento);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaSemana4/Delete/5
        public ActionResult Delete(int id)
        {
            Persona myPerson = (from c in db.Personas where id == c.id select c).First();
            return View(myPerson);
        }

        // POST: PersonaSemana4/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Persona myPerson = (from c in db.Personas where id == c.id select c).First();
                db.sp_delete_personas(myPerson.IDN);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

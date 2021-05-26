using Charity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        modelEntities dbObj = new modelEntities();
        private object model;

        public ActionResult Person(tb_person obj)

        {
                return View(obj);  
        }

       [HttpPost]
       public ActionResult AddPerson(tb_person model)
        {
            tb_person obj = new tb_person();
            if (ModelState.IsValid)
            {
                obj.ID = model.ID;
                obj.FName = model.FName;
                obj.LName = model.LName;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Price = model.Price;

                if (model.ID == 0)
                {
                    dbObj.tb_person.Add(obj);
                    dbObj.SaveChanges();
                }

                else
                {
                    dbObj.Entry(obj).State = System.Data.EntityState.Modified;
                    dbObj.SaveChanges();
                }

            }
            ModelState.Clear();

            return View("Person");
        }


        public ActionResult Personlist()
        {
            var res = dbObj.tb_person.ToList();

            return View(res);
        }

        public ActionResult Delete(int id )
        {
            var res = dbObj.tb_person.Where(x => x.ID == id).First();
            dbObj.tb_person.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.tb_person.ToList();

            return View("Personlist", list);
        }
    }
}
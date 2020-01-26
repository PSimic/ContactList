    using System.Linq;
    using ContactList.Models;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    namespace ContactList
    {
        public class RolesController : Controller
        {
            algoccportalContext db = new algoccportalContext();
            public ActionResult Index()
            {
                return View(db.Roles.ToList());
            }
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult CreateRole(Roles role){
                db.Roles.Add(role);
                db.SaveChanges();
                return RedirectToAction("Index", "Roles");
            }
            [HttpPost]
            public bool Delete(int id){
                try
                {
                    Roles role = db.Roles.Where(s => s.Pkey == id).First();
                    db.Roles.Remove(role);
                    db.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
            public ActionResult Update(int id){
                return View(db.Roles.Where(s => s.Pkey == id).First());
            }
            [HttpPost]
            public ActionResult UpdateRole(Roles role){
                Roles r = db.Roles.Where(s => s.Pkey == role.Pkey).First();
                r.Type = role.Type;
                db.SaveChanges();
                return RedirectToAction("Index", "Roles");
            }
        }
    }
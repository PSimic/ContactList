    using System.Linq;
    using ContactList.Models;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    namespace ContactList
    {
        public class UsersController : Controller
        {
            algoccportalContext db = new algoccportalContext();
            public ActionResult Index()
            {
                return View(db.Users.ToList());
            }
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult CreateUser(Users user){
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "Users");
            }
            [HttpPost]
            public bool Delete(int id){
                try
                {
                    Users user = db.Users.Where(s => s.Pkey == id).First();
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
            public ActionResult Update(int id){
                return View(db.Users.Where(s => s.Pkey == id).First());
            }
            [HttpPost]
            public ActionResult UpdateUser(Users user){
                Users u = db.Users.Where(s => s.Pkey == user.Pkey).First();
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Email = user.Email;
                u.Password = user.Password;
                u.RolesPkey = user.RolesPkey;
                db.SaveChanges();
                return RedirectToAction("Index", "Users");
            }
        }
    }
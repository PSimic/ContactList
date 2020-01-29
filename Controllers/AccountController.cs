using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using ContactList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ContactList
{
    public class AccountController : Controller
        {
        algoccportalContext db = new algoccportalContext();
        public IActionResult Login()
        {
            return View();
        }
        public ActionResult Validate(Users user)
        {
            var _user = db.Users.Where(s => s.Email == user.Email).FirstOrDefault();
            if  (_user != null)
            {
                if  (_user.Password == user.Password)
                {
                    HttpContext.Session.SetString("Email", _user.Email);
                    HttpContext.Session.SetInt32("Pkey", _user.Pkey);
                    HttpContext.Session.SetInt32("RolesPkey", (int)_user.RolesPkey);
                    HttpContext.Session.SetString("FirstName", (_user.FirstName));
                    HttpContext.Session.SetString("LastName", (_user.FirstName));
                    int rolePkey = (int)HttpContext.Session.GetInt32("RolesPkey");
                    List<int> menus = db.LinkRolesMenus.Where(s => s.RolesPkey == rolePkey).Select(x => x.MenusPkey).ToList();
                    DataSet ds = new DataSet();
                    ds = ToDataSet(menus);
                    DataTable table = ds.Tables[0];
                    DataRow[] parentMenus = table.Select("parent_pkey = 0");
                    var sb = new StringBuilder();
                    string menuString = GenerateUL(parentMenus, table, sb);
                    HttpContext.Session.SetString("menuString", menuString);
                    HttpContext.Session.SetString("menus", JsonConvert.SerializeObject(menus));
                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = true, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }
        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string url = dr["Url"].ToString();
                    string menuText = dr["Name"].ToString();
                    string icon = dr["Icon"].ToString();
                    if (url != "#")
                    {
                        string line = String.Format(@"<li><a href=""{0}""><i class=""{2}""></i> <span>{1}</span></a></li>", url, menuText, icon);
                        sb.Append(line);
                    }
                    string pid = dr["Id"].ToString();
                    string parentId = dr["ParentId"].ToString();
                    DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals(parentId))
                    {
                        string line = String.Format(@"<li class=""treeview""><a href=""#""><i class=""{0}""></i> <span>{1}</span><span class=""pull-right-container""><i class=""fa fa-angle-left pull-right""></i></span></a><ul class=""treeview-menu"">", icon, menuText);
                        var subMenuBuilder = new StringBuilder();
                        sb.AppendLine(line);
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder));
                        sb.Append("</ul></li>");
                    }
                }
            }
            return sb.ToString();
        }
        public DataSet ToDataSet<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            return ds;
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}
using MVCFameDocs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFameDocs.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListUsers()
        {

            List<UserModel> finalUserList = new List<UserModel>();

            finalUserList.Add(new UserModel { UserFirstName = "Jimmy", UserLastName = "Sietsma", UserName = "jsietsma", UserEmail = @"jsietsma@nycwatershed.org", UserChange = true, UserCreate = true, UserDelete = true });
            finalUserList.Add(new UserModel { UserFirstName = "Jeff", UserLastName = "NewGuy", UserName = "jnewguy", UserEmail = @"jnewguy@nycwatershed.org", UserChange = false, UserCreate = false, UserDelete = false });
            finalUserList.Add(new UserModel { UserFirstName = "Sally", UserLastName = "Altman", UserName = "saltman", UserEmail = @"saltman@nycwatershed.org", UserChange = true, UserCreate = true, UserDelete = false });
            finalUserList.Add(new UserModel { UserFirstName = "Robert", UserLastName = "Assistman", UserName = "rassistman", UserEmail = @"rassistman@nycwatershed.org", UserChange = false, UserCreate = true, UserDelete = false });
            finalUserList.Add(new UserModel { UserFirstName = "Guest", UserName = "guest", UserChange = false, UserCreate = false, UserDelete = false });

            return View(finalUserList);

        }

    }
}
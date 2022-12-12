using GISApp.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace GISApp.Controllers
{
    public class HomeController : Controller
    {
        //Index
        public IActionResult Index()
        {
            return View();
        }

        //Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        //Testdata
        public List<Accounts> Values()
        {
            var accounts = new List<Accounts>
            {
                new Accounts{ Id = 1, UserName="Per", Password="Persen1"},
                new Accounts{ Id = 2, UserName="Mia", Password="Miasen2"},
                new Accounts{ Id = 3, UserName="Odd", Password="Oddsen3"},
                new Accounts{ Id = 4, UserName="Ida", Password="Idasen4"}
            };

            return accounts;
        }

        //Login
        public IActionResult Login(Accounts acc)
        {
            var user = Values();

            var vUser = user.Where(u => u.UserName.Equals(acc.UserName));
            var vPass = vUser.Where(p => p.Password.Equals(acc.Password));

            if (vPass.Count() == 1)
            {
                return View("Maps");
            }
            else
            {
                return View("Login");
            }
        }
    }
}
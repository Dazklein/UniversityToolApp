using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StateApp.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Login() => View();

        public IActionResult Register() => View();
    }
}

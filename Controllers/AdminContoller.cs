using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Htest.Models;
using System.IO;
using OfficeOpenXml;

namespace Htest.Controllers
{
    public class AdminController : Controller
    {

        public class StatisticsDTO{
            

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
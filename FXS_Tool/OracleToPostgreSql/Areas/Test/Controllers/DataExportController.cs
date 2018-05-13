using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OracleToPostgreSql.Areas.Test.Controllers
{
    public class DataExportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
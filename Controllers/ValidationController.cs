using Microsoft.AspNetCore.Mvc;
using TempManager.Models;
using System;
using System.Linq;
//exercise 11-1
namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext Context { get; set; }
        public ValidationController(TempManagerContext ctx)
        {
            Context = ctx;
        }
        public JsonResult CheckDate(string date)
        {
            DateTime dateValue = Convert.ToDateTime(date);
            Temp temp = Context.Temps.FirstOrDefault(T => T.Date == dateValue);

            if (temp == null)
                return Json(true);
            else 
            return Json("That date is in the database already.");

            }
        }
    }


using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGame.Models;
using WebApplication1.Utility;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }         
        TempResult tempResult = new TempResult();
        [HttpPost]
        public IActionResult Index(DoctorModel temprature)
        {                       
            var sessionNumber = HttpContext.Session.GetInt32("SessionNumber");
            var guess = tempResult.GetResult(ref temprature);
            var message="";
            if (int.Parse(guess) > sessionNumber)
            {
                message = "Too high, and let you take another gues";
            }
            else if(int.Parse(guess) < sessionNumber)
            {
                message = "Too low, and let you take another gues";
            }
            else if(int.Parse(guess) == sessionNumber)
            {
                message = " congratulating you on your success";
                MyModel randomModel = new MyModel();
                randomModel.GetGuessNumber();
                HttpContext.Session.SetInt32("SessionNumber", randomModel.MyNumber);
            }
            ViewBag.TempResult = message;
            return View();
        }
    }
}

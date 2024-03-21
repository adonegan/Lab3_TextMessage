using Lab3TextMessage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3TextMessage.Controllers
{
    public class TextController : Controller
    {
        
        public ActionResult SentConfirmed()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(TextMessage _Text)
        {
            //Text1.TextContent = _Text.TextContent;
            return RedirectToAction("Success");
        }

        public ActionResult Success() 
        {
            ViewBag.SuccessMessage = "Success! You've sent your text!";
            return View();
        }

        
    }
}

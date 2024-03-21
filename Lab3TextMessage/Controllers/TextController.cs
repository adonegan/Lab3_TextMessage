using Lab3TextMessage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3TextMessage.Controllers
{
    public class TextController : Controller
    {
        
        public ActionResult SentConfirmed(TextMessage _Text)
        {
            return View(_Text);
        }

        [HttpGet]
        public ActionResult Send()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Send(TextMessage _Text)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("SentConfirmed", _Text);
            }
            else
            {
                return View();
            }
        }
    }

}

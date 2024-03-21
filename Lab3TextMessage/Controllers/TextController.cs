using Lab3TextMessage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3TextMessage.Controllers
{
    public class TextController : Controller
    {
        TextMessage Text1 = new TextMessage() {DestinationPhone="5555555555", TextContent=" " }; 
        
        public ActionResult Display()
        {
            return View(Text1);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(Text1);
        }

        [HttpPost]
        public ActionResult Edit(TextMessage _Text)
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

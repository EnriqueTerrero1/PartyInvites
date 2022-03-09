using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
     public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.greeting = hour < 12 ? "good morning" : "good afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]

        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //TODO: store response from guest
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("thanks", guestResponse);
            }else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult ListResponses()
        {


            return View (Repository.Responses.Where(r => r.willAttend == true));
        }
        
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace callingCard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{firstName}/{lastName}/{age}/{favoriteColor}")]
        public JsonResult CallingCard(string firstName, string lastName, int age, string favoriteColor)
        {
            var cardData = new {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                color = favoriteColor
            };
            return Json(cardData);
        }
    }
}

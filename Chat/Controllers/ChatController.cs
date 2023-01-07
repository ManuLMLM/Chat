using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Chat.Controllers
{

    public class ChatController : Controller
    {
        public static Dictionary<int,string> Rooms = new Dictionary<int, string>()
        {
            {1,"Familia" },
            {2,"Trabajo" },
            {3,"Amigos" },
            {4,"Estudios" }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}

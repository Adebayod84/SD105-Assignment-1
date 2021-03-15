using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using static WebApplication1.Models.Hotel;

namespace WebApplication1.Controllers
{
    public class HotelController : Controller
    {
        List<Room> AllRooms = new List<Room>();
        List<Client> AllClients = new List<Client>();
        public IActionResult Index()
        {
            return View();
        }



        public Room GetRoom(string roomNumber)
        {
            return AllRooms.Where(r => r.Rooms== roomNumber).ToList();
        }

        public Client getClient(int ID)
        {
            return AllClients.Where(c => c.Name == ID).ToList();
        }

        public Reservation getReservation(int ID)
        {
            return AllRooms.Where(rs => rs.)
        }
        
    }

    
}

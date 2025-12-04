using FlightManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagment.Controllers
{
    public class TicketController : Controller
    {
        
        public static List<FlightTicket> tickets = new()
    {
        new FlightTicket{ Id=1, Country="Turkey", City="Antalya", Price=320, HotelName="Sun Hotel"},
        new FlightTicket{ Id=2, Country="UAE", City="Dubai", Price=600, HotelName="Palm Resort"},
        new FlightTicket{ Id=3, Country="Italy", City="Rome", Price=450, HotelName="Roma Inn"}
    };

        
        public static List<FlightTicket> BoughtTickets = new();


        public IActionResult Index()
        {
            return View(tickets);
        }

        public IActionResult Detail(int id)
        {
            var ticket = tickets.FirstOrDefault(x => x.Id == id);
            return View(ticket);
        }


        public IActionResult Buy(int ticketId, int userId)
        {
            var ticket = tickets.FirstOrDefault(x => x.Id == ticketId);
            
            BoughtTickets.Add(ticket);

            TempData["msg"] = "Ticket successfully purchased!";
            return RedirectToAction("Detail", new { id = ticketId });
        }

        public IActionResult Bought()
        {
            return View(BoughtTickets);
        }

    }

}

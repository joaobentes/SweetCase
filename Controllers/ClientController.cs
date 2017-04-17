using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using SS_Case.Models;

namespace SS_Case.Controllers
{
    public class ClientController: Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var client = _context.Clients.FirstOrDefault(e => e.ClientID == id);
            return View(client);
        }

        public IActionResult Delete(int id)
        {
            var original = _context.Clients.FirstOrDefault(e => e.ClientID == id);
            if(original != null)
            {
                _context.Clients.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Index() 
        {
            var model = _context.Clients.ToList();
            ViewBag.CountryList = _context.Countries.ToList();

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
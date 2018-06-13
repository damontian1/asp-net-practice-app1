using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp_practice_app.Context;
using asp_practice_app.Models;

namespace asp_practice_app.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactsDbContext _context;

        public ContactsController(ContactsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Contacts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
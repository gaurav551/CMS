using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PremiumAccount.Data;
using PremiumAccount.Models;

namespace PremiumAccount.Controllers
{
    public class contactController : Controller
    {
        private ApplicationDbContext _context;
        public contactController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult SaveContact(Contact c)
        {
              TempData["name"] = c.Email;
            _context.Contacts.Add(c);
            _context.SaveChanges();
           
            
            return RedirectToAction("ThankYou");
        }
        public IActionResult ThankYou()
        {
            if (TempData["name"]==null)
            {
               return RedirectToAction(nameof(Index));
            }
            else
            {
            return View();
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Services;

namespace WebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedoresService _vendedoresService;

        public VendedoresController(VendedoresService vendedoresService)
        {
            _vendedoresService = vendedoresService;
        }

        public IActionResult Index()
        {
            var list = _vendedoresService.FindAll();
            return View(list);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
using WebMvc.Models.ViewModels;
using WebMvc.Services;

namespace WebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedoresService _vendedoresService;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedoresService vendedoresService, DepartamentoService departamentoService)
        {
            _vendedoresService = vendedoresService;
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var list = _vendedoresService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var departamentos = _departamentoService.FindAll();
            var viewModel = new VendedorFormViewModel { Departamento = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedores vendedores)
        {
            _vendedoresService.Insert(vendedores);
            return RedirectToAction(nameof(Index));
        }
    }
}
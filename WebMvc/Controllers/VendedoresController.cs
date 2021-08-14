using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
using WebMvc.Models.ViewModels;
using WebMvc.Services;
using WebMvc.Services.Exceptions;

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

        //Ação para pegar todos departamentos e enviar para a view
        public IActionResult Create()
        {
            var departamentos = _departamentoService.FindAll();
            var viewModel = new VendedorFormViewModel { Departamento = departamentos };
            return View(viewModel);
        }

        //Ação para criar um novo vendedor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedores vendedores)
        {
            _vendedoresService.Insert(vendedores);
            return RedirectToAction(nameof(Index));
        }

        //Açao para recuperar o Id e enviar para a View
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido"});
            }

            var obj = _vendedoresService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        //Ação para efetuar a deleção no BD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _vendedoresService.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = _vendedoresService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = _vendedoresService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            List<Departamento> departamentos = _departamentoService.FindAll();
            VendedorFormViewModel viewModel = new VendedorFormViewModel { Vendedores = obj, Departamento = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Vendedores vendedores)
        {
            if (id != vendedores.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Ids não correspondem" });
            }

            try
            {
                _vendedoresService.Update(vendedores);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
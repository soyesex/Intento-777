﻿using Aplicacion.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProducto _service;
        public ProductoController(IProducto service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = await _service.GetAllAsync();
            return View(viewModel);
        }
    }
}

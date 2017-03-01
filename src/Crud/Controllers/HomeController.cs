using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crud.Services;
using Crud.ViewModels;
using Crud.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        IDataServices _services;
        public HomeController(IDataServices services)
        {
            _services = services;
        }


        public IActionResult Index()
        {
            IEnumerable<Product> list = _services.GetAll();
            GetDataViewModel vm = new GetDataViewModel
            {
                List = list,
                Time = DateTime.Now,
                Total = list.Count()
            };
            return View(vm);
        }

        public IActionResult Details(int id)
        {
            Product product = _services.GetById(id);
            GetDetailsViewModel vm = new GetDetailsViewModel
            {
                Id = product.ProductId,
                Name = product.Name,
                Details = product.Details,
                Type = product.Type
            };
            return View(vm);
        }

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Product p = new Product
                {
                    Name = vm.Name,
                    Details = vm.Details,
                    Type = vm.Type 
                };
                _services.Add(p);
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        public IActionResult Update(int id)
        {
            Product product = _services.GetById(id);
            UpdateProductViewModel vm = new UpdateProductViewModel
            {
                Name = product.Name,
                Details = product.Details,
                Type = product.Type
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Update(int id,UpdateProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Product pr = _services.GetById(id);
                pr.Name = vm.Name;
                pr.Details = vm.Details;
                pr.Type = vm.Type;
                return RedirectToAction("Index");
                
            }

            return View(vm);
        }

        public IActionResult Delete(int id)
        {
            _services.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using greystore.Models;
using Microsoft.AspNetCore.Authorization;

namespace greystore.Controllers
{
    [Authorize]

    public class AdminController : Controller
    {
        private IProductRepository repository;
        public AdminController(IProductRepository repo) { repository = repo; }
        public ViewResult Index() => View(repository.Products);
        public ViewResult Edit(int productId) => View(repository.Products.FirstOrDefault(p => p.ProductID == productId));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid) 
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {      
                return View(product);         
            } 

        }
        public ViewResult Create() => View("Edit", new Product());
    }
}

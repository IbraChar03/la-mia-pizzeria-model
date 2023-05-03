﻿using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using(PizzaContext pz = new PizzaContext()) {
            List<Pizza> list = pz.Pizzas.ToList();
            return View(list);
            }
   
        }
    }
}
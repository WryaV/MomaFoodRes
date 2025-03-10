﻿using Microsoft.AspNetCore.Mvc;
using MomaFoodRes.Data;
using MomaFoodRes.Models;

namespace MomaFoodRes.Controllers
    {
    public class IngredientController : Controller
        {
        private Repository<Ingredient> ingredients;
        public IngredientController(ApplicationDbContext context)
            {
            ingredients = new Repository<Ingredient>(context);
            }
        public async Task<IActionResult> Index()
            {
            return View(await ingredients.GetAllAsync());
            }
        }
    }

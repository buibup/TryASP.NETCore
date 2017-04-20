using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TryASP.NETCore.Models;

namespace TryASP.NETCore.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            var equipments = Equipment.GetAll();

            return View("Index", equipments);
        }

        public IActionResult Create(string EquipmentName)
        {
            var equipment = new Equipment();
            equipment.Name = EquipmentName;
            Equipment.Create(EquipmentName);

            return RedirectToAction("Index", equipment);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryASP.NETCore.Models
{
    public class Equipment
    {
        public string Name;

        public static void Create(string EquipmentName)
        {
            var equipment = new Equipment();
            equipment.Name = EquipmentName;
            GlobalVariables.Equipments.Add(equipment);
        }

        public static List<Equipment> GetAll()
        {
            return GlobalVariables.Equipments;
        }
    }
}

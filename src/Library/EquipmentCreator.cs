using System.Collections.Generic;
using System.Linq;
using Full_GRASP_And_SOLID;

namespace Library
{
    public static class EquipmentCreator
    {
        private static List<Equipment> equipmentCatalog = new List<Equipment>();

        public static Equipment CreateEquipment(string description)
        {
            Equipment existingEquipment = GetEquipment(description);

            if (existingEquipment != null)
            {
                return existingEquipment;
            }

            AddEquipmentToCatalog(description, 0);
            return GetEquipment(description);
        }

        public static void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
        }

        private static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}
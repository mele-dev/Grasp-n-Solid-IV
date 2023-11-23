//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Library;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = ProductCreator.CreateProduct("Café con leche");
            recipe.AddStep(new Step(ProductCreator.CreateProduct("Café"), 100, EquipmentCreator.CreateEquipment("Cafetera"), 120));
            recipe.AddStep(new Step(ProductCreator.CreateProduct("Leche"), 200, EquipmentCreator.CreateEquipment("Hervidor"), 60));

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {
            ProductCreator.AddProductToCatalog("Café", 100);
            ProductCreator.AddProductToCatalog("Leche", 200);
            ProductCreator.AddProductToCatalog("Café con leche", 300);

            EquipmentCreator.AddEquipmentToCatalog("Cafetera", 1000);
            EquipmentCreator.AddEquipmentToCatalog("Hervidor", 2000);
        }
    }
}

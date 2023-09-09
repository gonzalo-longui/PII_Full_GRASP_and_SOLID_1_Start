//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public double GetProductionCost()
        {
            double total = 0;
            foreach (Step step in steps)
            {
                total += step.GetSubtotal();
            }
            return total;
        }
        //Principio SRP: Tiene la única responsabilidad de saber el costo de sí mismo
        //Principio Expert: Tiene toda la información que necesita para calcular su propio costo

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} kg de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} segundos");
            }
            Console.WriteLine($"Costo: ${Math.Round(GetProductionCost(),2)}");
        }
    }
}
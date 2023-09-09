//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        public double GetSubtotal()
        {
            double subtotal = this.Quantity * this.Input.UnitCost + this.Time * this.Equipment.HourlyCost/3600;
            return subtotal;
        }
        //Principio SRP: La única responsabilidad que tiene es saber su propio costo. Si quiero hacer más recetas con este paso, ya sabe su costo
        //Principio Expert: tiene toda la información que necesita para calcular su propio subtotal
    }
}
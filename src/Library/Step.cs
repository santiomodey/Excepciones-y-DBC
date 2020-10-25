//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            if (quantity<0)
            {
                throw new Exception(message: "La cantidad no puede ser menor a 0");
            }
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}
//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            if (hourlyCost<0)
            {
                throw new Exception(message: "El costo de la hora no puede ser menor a 0");
            }
            this.HourlyCost = hourlyCost;
            
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
    }
}
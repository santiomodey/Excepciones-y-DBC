//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;
namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            if (unitCost<0)
            {
                throw new Exception(message: "El valor del producto no puede ser menor a 0");
            }
            this.Description = description;
            this.UnitCost = unitCost;
            
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}
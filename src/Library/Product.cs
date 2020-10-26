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
            this.Description = description;
            this.UnitCost = unitCost;
            
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }

        internal bool IsNullOrEmpty()
        {
            throw new NotImplementedException();
        }
    }
}
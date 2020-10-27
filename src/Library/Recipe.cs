//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();
        private List<string> recipe = new List<string>();  

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public List<string> Receta() // Por patrón EXPERT la clase Recipe debe crear la receta porque es esta
                                     // quien conoce toda la información necesaria.
        {
            recipe.Clear();
            recipe.Add(this.FinalProduct.Description);
            foreach (Step step in this.steps)
            {
                recipe.Add(step.Frase());
            }
            return recipe;
        }
    }
}
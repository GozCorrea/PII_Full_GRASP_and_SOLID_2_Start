using System;
using System.Collections;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        // Se le quita la responsabilidad de imprimir a la clase Recipe para cumplir con SRP.
        // Esta clase solo sabe imprimir por consola. Esta clase también cumple con el patrón SRP
        // porque solo se encarga de imprimir la lista ingresada.
        public static void Printer(Recipe recipe)
        {
            foreach(string elem in recipe.Receta())
            {
                Console.WriteLine(elem);
            }
        }
    }
}
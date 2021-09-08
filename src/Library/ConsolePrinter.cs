using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public Recipe recetaa {get; set;}
        public ConsolePrinter(Recipe recipe2)
        {
            this.recetaa = recipe2;
            this.recetaa.steps = recipe2.steps;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Receta de {this.recetaa.FinalProduct.Description}:");
            foreach (Step step in this.recetaa.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
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

/*
Aqui se utiliza el principio SOLID para asignar la tarea de imprimir a otra clase
Así la clase de recipe no tiene que hacer varias tareas. Solo se ocupa de armar la receta,
y la clase ConsolePrinter utiliza esos datos y los imprime en consola. 
La clase recipe seria el experto porque contien todos los datos que necesitamos
*/
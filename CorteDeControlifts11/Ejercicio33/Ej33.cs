using System;
/*33.	Informar el máximo valor de un lote de n números reales.
    La cantidad de N números reales será ingresada por el usuario del programa. */
namespace Ejercicio33
{
    class Ej33
    {
        static void Main(string[] args)
        {
            //inicializamos variables
            int cantNum = 0;
            double valIng = 0;
            double numMax = 0;
            bool primerVal = true;

            Console.WriteLine("Ingrese la cantidad de numeros que va a ingresar");
            cantNum = int.Parse(Console.ReadLine());

            //este ciclo se repetira las veces que el usuario ingrese
            while (cantNum > 0)
            {
                //ingresamos el numero
                Console.WriteLine("Ingrese un valor");
                valIng = double.Parse(Console.ReadLine());

                //asignamos el valor maximo a la variable 
                if (!primerVal)
                {
                    numMax = valIng;
                }
                else
                {
                    primerVal = false;
                    numMax = valIng;
                }

                //decrementamos el contador
                cantNum--;
            }
            if (primerVal)
            {
                Console.WriteLine("No hay valores a comparar");
            }
            else
            {
                Console.WriteLine($"El valor maximo del lote es {numMax}");
            }
            
        }
    }
}

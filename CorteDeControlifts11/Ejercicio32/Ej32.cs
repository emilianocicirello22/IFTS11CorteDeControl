using System;
/*32.	Informar el valor máximo de un conjunto de números reales que 
        finaliza con valor 0, el cual pertenece al conjunto. Se lee al menos un valor.
*/
namespace Ejercicio32
{
    class Ej32
    {
        static void Main(string[] args)
        {
            //inicializamos variables
            bool primerVal = true;
            double valMax = 0;
            double valIngresado = 0;

            //ingresamos el promer valor
            Console.WriteLine("Ingrese un valor distinto a 0 para iniciar");
            valIngresado = double.Parse(Console.ReadLine());

            //iniciamos el ciclo while 
            while (valIngresado != 0)
            {
                //la variable booleana nos permitira inicializar el primer valor
                if (!primerVal)
                {
                    //comparamos el numero ingresado
                    if (valMax < valIngresado)
                    {
                        valMax = valIngresado;
                    }
                }
                //al entrar por falsa inicializamos el pimer valor
                else
                {
                    //cambiamos la variable a falsa para poder comparar el numero
                    primerVal = false;
                    valMax = valIngresado;
                }
                //ingresamos nuevamente el numero
                Console.WriteLine("Ingrese numero / para finalizar ingrese 0");
                valIngresado = double.Parse(Console.ReadLine());
            }
            //mostramos los datos
            if (!primerVal)
            {

                Console.WriteLine($"El mayor valor es {valMax}");
            }
            else
            {
                Console.WriteLine($"no se ingresaron valores");
            }

        }
    }
}

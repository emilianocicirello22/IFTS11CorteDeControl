using System;

namespace Ejercicio35
{
    class Ej35
    {
        static void Main(string[] args)
        {
            //declaramos variables
            double nroIng = 0, nroComp = 0, nroMax = 0;
            int contNroMax = 0;
            bool maximo = true;

            //Iniciamos ciclo de repeticion
            do
            {
                //ingresamos datos
                Console.WriteLine("Ingrese un numero\nPara finalizar ingrese 0");
                nroIng = double.Parse(Console.ReadLine());

                //preguntamos si el nro ingresado es distinto a 0
                if (nroIng != 0)
                {
                    //if para iniciar y comparar el maximo 
                    if (maximo)
                    {
                        //iniciamos el primer valor
                        nroMax = nroIng;

                        //cambiamos el valor de la variable a falso
                        maximo = false;

                        //iniciamos el valor para comparar si se repite el valor maximo
                        nroComp = nroMax;

                    }
                    else
                    {
                        //preguntamos si el valor ingesado es mayor al valor maximo
                        if (nroIng >= nroMax)
                        {
                            //guardamos el valor
                            nroMax = nroIng;

                            //preguntamos si el valor maximo es igual al ultimo valor maximo registrado
                            if (nroMax == nroComp)
                            {
                                //si es igual lo contamos en la variable
                                contNroMax++;
                            }
                            else
                            {
                                //si no lo reasignamos
                                nroComp = nroMax;
                            }

                        }
                    }
                }
            } while (nroIng != 0);

            //mostramos datos
            Console.WriteLine($"El numero mayor es {nroMax} y se repite {contNroMax}");

        }
    }
}

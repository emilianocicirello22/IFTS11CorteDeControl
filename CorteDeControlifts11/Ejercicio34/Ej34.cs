using System;
/*34.	Dado un listado conlos nombres y las 4 notas obtenidas por los alumnos de un curso, 
 * calcular e informar el promedio de cada uno y una leyenda que indique si está o no aprobado. 
 * No se conoce la cantidad total de alumnos a procesar. De acuerdo a cada versión utilice 
 * la estructura de repetición más adecuada.
•	Versión con listado de alumnos de 1 a n
•	Versión con listado de 50 alumnos
•	Versión con listado de 0 o n alumnos
*/
namespace Ejercicio34
{
    class Ej34
    {
        static void Main(string[] args)
        {
            //inicializamos variables
            String nombre = "";
            double notas = 0;
            double promedio = 0;
            int cantidadAlumnos = 0;
            String aprobado = "";
            bool checkDatos = true;
            /*

            //////Versión con listado de alumnos de 1 a n/////
            
            
            do
            {
                //ingresamos en nombre del alumno
                Console.WriteLine("ingrese nombre del alumno");
                nombre = Console.ReadLine();

                //ingresamos las notas
                for(int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"Ingrese nota numero {i}");
                    notas = double.Parse(Console.ReadLine());

                    //acumulamos el promedio
                    promedio += notas;
                }

                //calculamos promedio
                promedio = promedio / 4;

                //preguntamos si esta aprobado o desaprobado
                if (promedio >= 6)
                {
                    aprobado = "Aprobó";
                }
                else
                {
                    aprobado = "Desaprobó";
                }

                //mostramos los datos
                Console.WriteLine($"El alumno {nombre}, {aprobado} con un promedio de {promedio}");

                //preguntamos si quiere seguir cargando alumnos no finalizar
                Console.WriteLine("Para continuar ingrese 1 \n para finalizar ingrese 0");
                cantidadAlumnos = int.Parse(Console.ReadLine());
                
                //Reinicio la variable promedio
                promedio = 0;

            } while (cantidadAlumnos != 0);

            

            /////////////////////////////////////////////////////////////////////////////////////////
            
            
            
            /////Versión con listado de 50 alumnos/////



            //Cargamos y mostramos 50 veces los datos
            for(int i = 0; i < 50; i++)
            {
                //ingresamos en nombre del alumno
                Console.WriteLine("ingrese nombre del alumno");
                nombre = Console.ReadLine();

                //ingresamos las notas
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine($"Ingrese nota numero {j}");
                    notas = double.Parse(Console.ReadLine());

                    //acumulamos el promedio
                    promedio += notas;
                }

                //calculamos promedio
                promedio = promedio / 4;

                //preguntamos si esta aprobado o desaprobado
                if (promedio >= 6)
                {
                    aprobado = "Aprobó";
                }
                else
                {
                    aprobado = "Desaprobó";
                }

                //mostramos los datos
                Console.WriteLine($"El alumno {nombre}, {aprobado} con un promedio de {promedio}");

                //Reinicio la variable promedio
                promedio = 0;

            }

            

            /////////////////////////////////////////////////////////////////////////////////////////

            /////Versión con listado de 0 o n alumnos/////



            Console.WriteLine("Ingrese 1 para cargar datos \n 0 para finalizar");
            cantidadAlumnos = int.Parse(Console.ReadLine());

            while (cantidadAlumnos != 0)
            {
                //esta variable permite chequear si se ingreso un dato
                checkDatos = false;

                //ingresamos en nombre del alumno
                Console.WriteLine("ingrese nombre del alumno");
                nombre = Console.ReadLine();

                //ingresamos las notas
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine($"Ingrese nota numero {j}");
                    notas = double.Parse(Console.ReadLine());

                    //acumulamos el promedio
                    promedio += notas;
                }

                //calculamos promedio
                promedio = promedio / 4;

                //preguntamos si esta aprobado o desaprobado
                if (promedio >= 6)
                {
                    aprobado = "Aprobó";
                }
                else
                {
                    aprobado = "Desaprobó";
                }

                //mostramos los datos
                Console.WriteLine($"El alumno {nombre}, {aprobado} con un promedio de {promedio}");

                //Reinicio la variable promedio
                promedio = 0;

                //pregunamos si quiere seguir cargando datos
                Console.WriteLine("Ingrese 1 para cargar datos \n 0 para finalizar");
                cantidadAlumnos = int.Parse(Console.ReadLine());
            }

            //mensaje si no se ingresaron datos
            if (checkDatos)
            {
                Console.WriteLine("No se ingresaron datos");
            }

            */
        }
    }
}

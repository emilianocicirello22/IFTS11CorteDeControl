using System;
/*36.	Una gran cadena de electrodoméstico recibe mensualmente un informe consolidado de todas sus sucursales  conteniendo la siguiente información:
•	Código de sucursal (alfabético 3 caracteres) 
•	Producto vendido (alfabético 5 caracteres)
•	Cantidad vendida (numérico entero)

El listado se encuentra ordenado por código de sucursal, producto y cantidad vendida.

Se pide informar:
	Cantidad total vendida por cada sucursal Respetando la siguiente leyenda “La sucursal XXX vendióyyyyyy productos”
	Sucursal con la mejor venta, se debe respetar la siguiente leyenda: “La sucursal con mejor venta fue XXX y vendióyyyyy  productos”
 */
namespace IFTS11CorteDeControlUnidad3
{
    class Ej36
    {
        static void Main(string[] args)
        {
            String codigoSucursal = "";
            String productoVendido = "";
            int cantidadVendida = 0;
            String codigoSucAux = "";
            int cantVsucursal = 0;
            String sucMasVentas = "";

           Console.WriteLine("Ingrese codigo de sucursal");
            codigoSucursal = Console.ReadLine();
            codigoSucAux = codigoSucursal;

            while (!codigoSucursal.Equals("Y"))
            {
                while (codigoSucursal.Equals(codigoSucAux))
                {

                    Console.WriteLine("Ingrese Producto");
                    productoVendido = Console.ReadLine();

                    Console.WriteLine("Ingrese cantidad vendida");
                    cantidadVendida = int.Parse(Console.ReadLine());
                    cantidadVendida += cantidadVendida;

                    Console.WriteLine("Ingrese codigo de sucursal Para finalizar ingrese Y");
                    codigoSucursal = Console.ReadLine();
                }

                Console.WriteLine("La Sucursal: " + codigoSucAux + " Vendio " + cantidadVendida + " Productos");

                if (cantVsucursal == 0)
                {

                    sucMasVentas = codigoSucAux;
                    cantVsucursal = cantidadVendida;

                }
                else
                {
                    if (cantVsucursal < cantidadVendida)
                    {

                        sucMasVentas = codigoSucAux;
                        cantVsucursal = cantidadVendida;
                    }
                }
                codigoSucAux = codigoSucursal;
                cantidadVendida = 0;

            }
            Console.WriteLine($"La sucursal con mejor venta fue {sucMasVentas} y vendió " {cantVsucursal} productos");
        }

    }
}
    
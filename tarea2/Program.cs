using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)
      
            {
                // Definir arreglos para almacenar la información de los productos
                int[] clave = new int[100];
                string[] descripcion = new string[100];
                int[] existencia = new int[100];
                int[] minimo = new int[100];
                double[] precioUnitario = new double[100];

                int opcion;
                do
                {
                    Console.WriteLine("1. Agregar productos");
                    Console.WriteLine("2. Venta de producto");
                    Console.WriteLine("3. Reabastecimiento de un producto");
                    Console.WriteLine("4. Actualizar el precio");
                    Console.WriteLine("5. Salir");
                    Console.Write("Ingrese la opción deseada: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarProductos(clave, descripcion, existencia, minimo, precioUnitario);
                            break;
                        case 2:
                            VentaProducto(clave, existencia, minimo);
                            break;
                        case 3:
                            ReabastecimientoProducto(clave, existencia);
                            break;
                        case 4:
                            ActualizarPrecio(clave, precioUnitario);
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }

                } while (opcion != 5);
            }

            static void AgregarProductos(int[] clave, string[] descripcion, int[] existencia, int[] minimo, double[] precioUnitario)
            {
                int i = 0;
                do
                {
                    Console.Write("Ingrese la clave del producto: ");
                    clave[i] = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese la descripción del producto: ");
                    descripcion[i] = Console.ReadLine();

                    Console.Write("Ingrese la existencia del producto: ");
                    existencia[i] = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el mínimo a mantener de existencia: ");
                    minimo[i] = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el precio unitario del producto: ");
                    precioUnitario[i] = double.Parse(Console.ReadLine());

                    i++;

                    Console.Write("¿Desea agregar otro producto? (S/N): ");
                } while (Console.ReadLine().ToUpper() == "S");
            }

            static void VentaProducto(int[] clave, int[] existencia, int[] minimo)
            {
                Console.Write("Ingrese la clave del producto a vender: ");
                int claveProducto = int.Parse(Console.ReadLine());

                int indice = Array.IndexOf(clave, claveProducto);

                if (indice != -1)
                {
                    Console.Write("Ingrese la cantidad vendida: ");
                    int cantidadVendida = int.Parse(Console.ReadLine());

                    existencia[indice] -= cantidadVendida;

                    if (existencia[indice] < minimo[indice])
                    {
                        Console.WriteLine("¡Atención! La existencia del producto está por debajo del mínimo.");
                    }
                    else
                    {
                        Console.WriteLine("Venta realizada con éxito.");
                    }
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }

            static void ReabastecimientoProducto(int[] clave, int[] existencia)
            {
                Console.Write("Ingrese la clave del producto a reabastecer: ");
                int claveProducto = int.Parse(Console.ReadLine());

                int indice = Array.IndexOf(clave, claveProducto);

                if (indice != -1)
                {
                    Console.Write("Ingrese la cantidad comprada: ");
                    int cantidadComprada = int.Parse(Console.ReadLine());

                    existencia[indice] += cantidadComprada;

                    Console.WriteLine("Reabastecimiento realizado con éxito.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }

            static void ActualizarPrecio(int[] clave, double[] precioUnitario)
            {
                Console.Write("Ingrese la clave del producto a actualizar: ");
                int claveProducto = int.Parse(Console.ReadLine());

                int indice = Array.IndexOf(clave, claveProducto);

                if (indice != -1)
                {
                    Console.Write("Ingrese el nuevo precio unitario: ");
                    precioUnitario[indice] = double.Parse(Console.ReadLine());

                    Console.WriteLine("Precio actualizado con éxito.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }
        }


    }


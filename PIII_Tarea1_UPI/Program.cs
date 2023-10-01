using System;
using System.Linq;

//Jose Antonio Valerio.

namespace PIII_Tarea1_UPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do //primero ejecuta y luego evalua.
            {
                Console.Clear();
                Console.WriteLine("1. Ejercicio 1 - Tienda de Camisas.");
                Console.WriteLine("2. Ejercicio 2 - Cáculo de promedio.");
                Console.WriteLine("3. Ejercicio 3 - Venta por productos.");
                Console.WriteLine("4. Salir.");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear ();
                        Ejercicio1();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar el sistema.");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta.");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 4); // El while primero ejecuta y luego evalua.
        }

        public static void Ejercicio1()
        {
            float precio = 0;
            int cantidad;
            Console.WriteLine("Digite el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de camisas: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine("La compra no posee descuento.");
                Console.WriteLine($" El precio de la camisa es de {cantidad * precio}");
            }
            else if (cantidad == 2 && cantidad <= 5)
            {
                Console.WriteLine("La compra si posee descuento de 15%.");
                float descuento = (precio * cantidad) * 0.15f;
                Console.WriteLine($" El precio total de las camisa es de {(precio * cantidad) - descuento}");
                Console.WriteLine($" El descuento fue de: {descuento}");
            }
            else if (cantidad >= 6)
            {
                Console.WriteLine("La compra si posee descuento de 20%.");
                float descuento = (precio * cantidad) * 0.20f;
                Console.WriteLine($" El precio total de las camisa es de {(precio * cantidad) - descuento}");
                Console.WriteLine($" El descuento fue de: {descuento}");
            }
            Console.ReadLine();
        }
        public static void Ejercicio2()
        {
            string carnet = "", estado = "";
            string estudiante = "";
            float[] quices = new float[3];
            float[] tareas = new float[3];
            float[] examenes = new float[3];
            double[] promedios = new double[3];

            double PromQuiz = 0;
            double PromTareas = 0;
            double PromExamenes = 0;
            double PromFinal = 0.0f;

            Console.WriteLine("Ingrese el numero de carnet del estudiante: ");
            carnet = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante a evaluar: ");
            estudiante = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la nota del Quiz #{i + 1}: ");
                quices[i] = float.Parse(Console.ReadLine());
                PromQuiz += quices[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la nota de la Tarea #{i + 1}: ");
                tareas[i] = float.Parse(Console.ReadLine());
                PromTareas += tareas[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la nota del Examen #{i + 1}: ");
                examenes[i] = float.Parse(Console.ReadLine());
                PromExamenes += examenes[i];
            }

            PromQuiz = Queryable.Average(quices.AsQueryable());
            PromTareas = Queryable.Average(tareas.AsQueryable());
            PromExamenes = Queryable.Average(examenes.AsQueryable());

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    promedios[i] = (PromQuiz * 25) / 100;
                }
                else if (i == 1)
                {
                    promedios[i] = (PromTareas * 30) / 100;
                }
                else if (i == 2)
                {
                    promedios[i] = (PromExamenes * 45) / 100;
                }
                PromFinal += promedios[i];
            }

            if (PromFinal >= 70)
            {
                estado = "Aprobado";
            }
            else if (PromFinal < 70 & PromFinal >= 50)
            {
                estado = "Aplazado";
            }
            else if (PromFinal < 50)
            {
                estado = "Reprobado";
            }
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine($"Estudiante: {estudiante}");
            Console.WriteLine($"El promedio en porcentaje de los quices es: {Math.Round(promedios[0],2)}%");
            Console.WriteLine($"El promedio en porcentaje de las tareas es: {Math.Round(promedios[1],2)}%");
            Console.WriteLine($"El promedio en porcentaje de los examenes es: {Math.Round(promedios[2],2)}%");
            Console.WriteLine($"El promedio final es: {Math.Round(PromFinal, 2)}");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"El estado del estudiante es: {estado} ");
            Console.WriteLine($"--------------------------------------");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Ejercicio3()
        {
            int cantidad = 0;
            Console.WriteLine("Digite la cantidad de productos: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad >0 & cantidad <= 10)
            {
                Console.WriteLine("El precio por articulo es de $20.");
                Console.WriteLine($"El total a pagar es de: ${cantidad * 20}");
            }
            else if (cantidad > 10)
            {
                Console.WriteLine("El precio por articulo es de $15.");
                Console.WriteLine($"El total a pagar es de: ${cantidad * 15}");
            }
            else
            {
                Console.WriteLine("El valor ingresado es incorrecto.");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            double x = 0;
            double y = 0;
            double resultado = 0;
            string opcion = "";

            // Nuestra variable de referencia al algoritmo
            // Instanciamos con un default para permitir compilacion correcta
            IOperacion operacion = new Suma();

            do
            {
                Console.WriteLine("1- Suma, 2- Resta, 3- Multiplicacion, 4- Division, 5- Salir");
                opcion = Console.ReadLine();

                if (opcion == "5")
                    break;

                Console.WriteLine("Dame el valor de a");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Dame el valor de b");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                // Selecionamos el algoritmo
                switch (opcion)
                {
                    case "1":
                        operacion = new Suma();
                        break;
                    case "2":
                        operacion = new Resta();
                        break;
                    case "3":
                        operacion = new Multiplicacion();
                        break;
                    case "4":
                        operacion = new Division();
                        break; 
                    default:
                        Console.WriteLine("No elegiste la opcion correcta");
                        break;
                }

                resultado = operacion.operacion(x, y);
                Console.WriteLine("El resultado es {0}", resultado, ConsoleColor.Blue);
                Console.WriteLine();

            } while (opcion != "5");
        }
    }
}

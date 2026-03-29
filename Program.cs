using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DClase1Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int options = -1;

            while (options != 0)
            {
                Console.WriteLine("\n===== MENÚ =====");
                Console.WriteLine("1. Rectángulo (Área y Perímetro)");
                Console.WriteLine("2. Triángulo (Área)");
                Console.WriteLine("3. Año bisiesto");
                Console.WriteLine("4. Calculadora simple");
                Console.WriteLine("5. Calculadora continua");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Rectangle();
                        break;

                    case 2:
                        Triangle();
                        break;

                    case 3:
                        LeapYear();
                        break;

                    case 4:
                        SimpleCalculator();
                        break;

                    case 5:
                        ContinuousCalculator();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }
        static void Rectangle()
        {
            float b, h;
            Console.Write("Ingrese la base");
            b = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del rectangulo es {b*h}");
            Console.WriteLine($"El perimetro del rectangulo es {b+b+h+h}");
        }
        static void Triangle()
        {
            float b, h;
            Console.Write("Ingrese la base");
            b = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del triangulo es {b * h}");
        }
        static void LeapYear()
        {
            int y;
            Console.Write("Ingrese un año: ");
            y = Convert.ToInt32(Console.ReadLine());

            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("Es un año bisiesto");
            }
            else
            {
                Console.WriteLine("No es un año bisiesto");
            }
        }
        static void SimpleCalculator()
        {
            float n1, n2;
            string o;
            Console.Write("Ingrese el primer número: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la operación (+, -, *, /, %): ");
            o = Console.ReadLine();

            float r;

            switch (o)
            {
                case "+": 
                    r = n1 + n2; 
                    break;
                case "-": 
                    r = n1 - n2; 
                    break;
                case "*": 
                    r = n1 * n2; 
                    break;
                case "/": 
                    r = n2 != 0 ? n1 / n2 : 0; 
                    break;
                case "%": 
                    r = n1 % n2;
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    return;
            }
            Console.WriteLine($"Resultado: {r}");
        }
        static void ContinuousCalculator()
        {
            float n1 = 0;
            bool c = true;

            Console.Write("Ingrese el primer número: ");
            n1 = float.Parse(Console.ReadLine());

            while (c)
            {
                string o;
                Console.Write("Ingrese la operación (+, -, *, /, %, o 's' para salir): ");
                o = Console.ReadLine();

                if (o == "S" || o == "S")
                {
                    c = false;
                    break;
                }

                float n2;
                Console.Write("Ingrese el segundo número: ");
                n2 = float.Parse(Console.ReadLine());

                switch (o)
                {
                    case "+":
                        n1 = n1 + n2;
                        break;
                    case "-":
                        n1 = n1 - n2;
                        break;
                    case "*":
                        n1 = n1 * n2;
                        break;
                    case "/":
                        n1 = n2 != 0 ? n1 / n2 : 0;
                        break;
                    case "%":
                        n1 = n1 % n2;
                        break;
                    default:
                        Console.WriteLine("Operación no válida");
                        return;
                }

                Console.WriteLine("Resultado actual: " + n1);
            }

            Console.WriteLine("Calculadora finalizada.");
        }
    }
}
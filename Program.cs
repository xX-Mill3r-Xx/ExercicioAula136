using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAula136.Entities;
using ExercicioAula136.Entities.Enunms;
using System.Globalization;

namespace ExercicioAula136
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> list = new List<Shapes>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shapes # {i} data: ");
                Inicio:
                Console.Write("Rectangle or Circle? (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color? (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));

                }
                else if (ch == 'c' || ch == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                else
                {
                    Console.WriteLine("Entre com uma variavel valida! ");
                    goto Inicio;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas:");

            foreach (Shapes shepes in list)
            {
                Console.WriteLine(shepes.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}

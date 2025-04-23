using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ионов_изгорев1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, discriminant, x1, x2;
            Console.Write("введите a: ");
            a =double.Parse(Console.ReadLine());
            Console.Write("введите b: ");
            b =double.Parse(Console.ReadLine());
            Console.Write("введите c: ");
            c = double.Parse(Console.ReadLine());
            discriminant = (b*b) - 4 * a * c; // вычисление дискриминанта
            x1 = 0; 
            x2 = 0; 
            if (discriminant > 0) 
            {
                x1 = (-b + Math.Sqrt(discriminant)) / 2 * a; //вычисление корней 
                x2 = (-b - Math.Sqrt(discriminant)) / 2 * a; //вычисление корней 
                Console.WriteLine(" корень уравнения: x1 = " + x1);
                Console.WriteLine(" корень уравнения: x2 = " + x2);
            }
            else if (discriminant == 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / 2 * a; //вычисление корней 
                x2 = x1;                                     // когда дискриминант равен нулю может быть только один корень 
                Console.WriteLine("корни уравнения: x1 = " + x1);
                Console.WriteLine("корни уравнения: x2 = " + x2);
            }
            else //(discriminant < 0)
            {
                discriminant *= -1; // *= оператор умножения и присваивания (присваивает переменной дискриминант отрицательное значение) 
                x1 = -b / 2 * a;                                //вычисление корней
                double zx1 = (Math.Sqrt(discriminant)) / 2 * a; //вычисление мнимой единицы
                x2 = -b / 2 * a;                                //вычисление корней
                double zx2 = (Math.Sqrt(discriminant)) / 2 * a; //вычисление мнимой единицы
                Console.WriteLine("комплексные корни уравнения: y1= " + x1 + $" + {zx1}i");
                Console.WriteLine("комплексные корни уравнения: y2= " + x2 + $" - {zx2}i");
            }
            Console.ReadKey();
        }
    }
}

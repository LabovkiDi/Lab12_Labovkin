using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Labovkin
{
    class Program
    {
       //напишем статический класс с 3 методами
        static class Circle
        {
            public static void GetCirclelength(double radius) 
            {
                double Circlelength = Math.PI * 2 * radius; 
                Console.WriteLine("Длина окружности равна {0:0.00}", Circlelength);
            }
            public static void GetSquare(double radius)
            {
                double Square = Math.PI * Math.Pow(radius, 2.0);
                Console.WriteLine("Площадь круга равна {0:0.00}", Square);
            }
            public static void GetPosition(double radius, double pointX, double pointY)
            {
                if (pointX <= radius && pointY <= radius)
                {
                    Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с радиусом {2}", pointX, pointY, radius);
                }
                else
                {
                    Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", pointX, pointY, radius);
                }
            }
        }
        static void Main(string[] args)
        {
            //проверка исключений
            try
            {
                Console.WriteLine("Введите радиус окружности: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.WriteLine("Радиус должен иметь положительное значение");
                    return;
                }
                Console.WriteLine("Введите координату X точки:");
                double pointX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Введите координату Y точки:");
                double pointY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                //вызов методов
                Circle.GetCirclelength(radius); 
                Circle.GetSquare(radius);
                Circle.GetPosition(radius, pointX, pointY);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода");
                return;
            }
            Console.ReadKey();
        }
    }
}

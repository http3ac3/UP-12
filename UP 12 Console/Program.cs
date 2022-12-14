using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UP_12_Console
{
    internal class Program
    {
        class Rectangle
        {
            private int a;
            private int b;

            public int A
            {
                get => a;
                set => a = value;
            }
            public int B
            {
                get => b;
                set => b = value;
            }
            public bool IsSquare => a == b;
            public int this[int index]
            {
                get => (index == 0) ? a : 
                    (index == 1) ? b : throw new Exception("Индекс в пределах допустимого дипазона [0, 1]");
                set
                {
                    switch (index)
                    {
                        case 0: a = value; break;
                        case 1: b = value; break;
                        default: throw new Exception("Индекс в пределах допустимого дипазона [0, 1]");
                    }
                }
            }

            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public void PrintSides()
            {
                Console.WriteLine($"Сторона а -> {a}");
                Console.WriteLine($"Сторона b -> {b}");
            }

            public int Perimeter() => a * 2 + b * 2;
            public int Square() => a * b;
            public static Rectangle operator ++ (Rectangle rec)
            {
                rec.a++; 
                rec.b++;
                return rec;
            }
            public static Rectangle operator --(Rectangle rec)
            {
                rec.a--;
                rec.b--;
                return rec;
            }
            public static Rectangle operator *(Rectangle rec, int scalar)
            {
                rec.a *= scalar;
                rec.b *= scalar;
                return rec;
            }
            public static explicit operator String (Rectangle rec)
            {
                return $"Прямоугольник: a -> {rec.a}, b -> {rec.b}";
            }
            public static explicit operator Rectangle(string s)
            {
                int a, b;
                Regex regex = new Regex(@"[1-9]+");
                MatchCollection matches = regex.Matches(s);
                if (matches.Count > 2) throw new Exception("Строка содержит больше двух определений сторон прямоугольника!");
                else if (matches.Count < 2) throw new Exception("Строка содержит меньше двух определений сторон прямоугольника!");
                a = int.Parse(matches[0].Value);
                b = int.Parse(matches[1].Value);
                return new Rectangle(a, b);
            }
            public static bool operator true(Rectangle rec)
            {
                return rec.a == rec.b;
            }
            public static bool operator false(Rectangle rec)
            {
                return rec.a != rec.b;
            }

        }
        static void Main()
        {
            int a, b;
            Console.Write("Введите сторону a -> ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Введите целое положительное число!\nВведите сторону a -> ");
            }
            Console.Write("Введите сторону b -> ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.Write("Введите целое положительное число!\nВведите сторону b -> ");
            }
            Rectangle rec = new Rectangle(a, b);
            rec.PrintSides();

            int index;
            Console.Write("Введите индекс (0 - сторона а, 1 - сторона b) -> ");
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.Write("Введите целое число!\nВведите индекс -> ");
            }

            try
            {
                Console.WriteLine($"Сторона -> {rec[index]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Инкремент сторон прямоугольника: ");
            rec++;
            rec.PrintSides();
            Console.WriteLine("Декремент сторон прямоугольника: ");
            rec--;
            rec.PrintSides();

            if (rec) Console.WriteLine("Прямоугольник является квадратом!");
            else Console.WriteLine("Прямоугольник не является квадратом!");

            int scalar;
            Console.Write("Введите скаляр -> ");
            while (!int.TryParse(Console.ReadLine(), out scalar) || scalar <= 0)
            {
                Console.Write("Введите целое положительное число!\nВведите скаляр -> ");
            }
            rec *= scalar;
            rec.PrintSides();

            
            Console.WriteLine($"Преобразованный прямоугольник в строку:\n{(String)rec}");
            Console.Write("Введите строку для преобразования ее в прямоугольник, введя длины двух сторон (a, b) -> ");
            string s = Console.ReadLine();
            try
            {
                Rectangle newRec = (Rectangle)s;
                newRec.PrintSides();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

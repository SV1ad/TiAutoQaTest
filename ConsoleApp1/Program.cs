using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Enter coordinate x of dot A");
            var ax = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A");
            var ay = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B");
            var bx = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B");
            var by = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C");
            var cx = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C");
            var cy = int.Parse(Console.ReadLine());

            var ac = GetSizeByTwoDots(ax, ay, cx, cy);
            var bc = GetSizeByTwoDots(cx, cy, bx, by);
            var ab = GetSizeByTwoDots(ax, ay, bx, by);
            Console.WriteLine($"Length of AB is: '{ab}'");
            Console.WriteLine($"Length of BC is: '{bc}'");
            Console.WriteLine($"Length of AC is: '{ac}'");
            
            var isEquilateral = (ab == bc && bc == ac && ab == ac) ? "" : "NOT";
            Console.WriteLine($"Triangle IS {isEquilateral} 'Equilateral'");  
            
            var isIsosceles = (ac == ab) ? "" : "NOT";
            Console.WriteLine($"Triangle IS {isIsosceles} 'Isosceles'");  
            
            var isRight = (Math.Sqrt(Math.Pow(ab, 2d) + Math.Pow(ac, 2d)) == bc) ? "" : "NOT";
            Console.WriteLine($"Triangle IS {isRight} 'Right'");
            var Perimeter = ab + ac + bc;
            for (int i = 0; i < Perimeter; i += 2)
            {
                Console.WriteLine($"{i}");
            }
        }
        
        public static double GetSizeByTwoDots(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2d) + Math.Pow(y2 - y1, 2d));
        } 

        
    }
}
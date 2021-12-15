using System;
using System.Collections.Generic;
using CalcArea;

namespace CheckingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Figure> figList = new();
                Figure triangle = new Triangle(3, 4, 5);
                Figure circle = new Circle(10);

                figList.Add(triangle);
                figList.Add(circle);

                foreach (Figure item in figList)
                {
                    Console.WriteLine($"Now we will talk about {item.Name}");
                    Console.WriteLine($"correctness of {item.Name} is {item.IsCorrect()}");
                    Console.WriteLine($"{item.Name} area is: { item.GetArea()}");
                }

                Console.WriteLine($"Is triangle has a right angle? - {((Triangle)triangle).HasRightAngle()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("There is an error in application \"{0}\"", ex.Message));
            }
        }
    }
}

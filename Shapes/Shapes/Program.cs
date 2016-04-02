using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = {new Shape(),
                                new Triangle(),
                                new Circle(),
                                new Quadrate(),
                                new Rectangle(),
                                new Trapezium()};

            for (int i = 0; i < shape.Length; i++)
            {
                 shape[i].Draw();
                 Console.WriteLine(shape[i].Square());
            }
            Console.WriteLine(Shape.Sum(shape));
            //Sum.Shape(shape);
            //Console.WriteLine(shape.Sum(Shape[] shape)); 
        




        }
    }
}

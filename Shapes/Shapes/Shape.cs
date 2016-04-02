using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        public string Color { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("фигура");
        }

        //int result;
        public virtual int Square()
        {
            int result = 1;
            return result;
        }
        //int sum = 0;

        public static int Sum(Shape[] shape)
        {
            int sum = 0;
            for (int i = 0; i < shape.Length; i++)
            {
                sum +=shape[i].Square();
            }
            return sum;

        }

    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("треугольник");
        }
        public override int Square()
        {
            int result = 2;
            return result;
        }


    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("круг");
        }
        public override int Square()
        {
            int result = 3;
            return result;
        }


    }
    public class Quadrate : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("квадрат");
        }
        public override int Square()
        {
            int result = 4;
            return result;
        }


    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("прямоугольник");
        }
        public override int Square()
        {
            int result = 5;
            return result;
        }


    }

    public class Trapezium : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("трапеция");
        }
        public override int Square()
        {
            int result = 6;
            return result;
        }


    }








}

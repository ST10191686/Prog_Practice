using System;


namespace Ice_1_PROG_
{
    public abstract class shapes
    {
        public abstract double CalcArea();

    }
    public class rectangle : shapes
    {
        public override double CalcArea()
        {
            double Base = 12;
            double height = 6;
            double area = Base * height;
            return area;
        }
    }
    public class triangle : shapes
    {
        public override double CalcArea()
        {
            double Base = 8;
            double height = 10;
            double area =0.5 * Base * height;
            return area;
        }
    }
    public class parallelogram : shapes
    {
        public override double CalcArea()
        {
            double Base = 8;
            double height = 12;
            double area = Base * height;
            return area;
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            shapes rectangle = new rectangle();
            Console.WriteLine("Area of rectangle : " + rectangle.CalcArea());

            shapes triangle = new triangle();
            Console.WriteLine("Area of triangle : " + triangle.CalcArea());

            shapes paragram = new parallelogram();
            Console.WriteLine("Area of paragram : " + paragram.CalcArea());
        }
    }
}

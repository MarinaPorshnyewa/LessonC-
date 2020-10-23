using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkInClass
{
    //Задача с занятия: задать фигуру и что вывести

    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager shapeManagerSquare = new ShapeManager(new Square(4), CompareOption.Perimeter);
            ShapeManager shapeManagerCircle = new ShapeManager(new Circle(4), CompareOption.Area);
            ShapeManager shapeManagerCircle2 = new ShapeManager(new Circle(6), CompareOption.Perimeter);
            ShapeManager shapeManagerTriangle = new ShapeManager(new Triangle(4,4,5), CompareOption.Area);
            ShapeManager[] shapeManagers = { shapeManagerSquare, shapeManagerCircle, shapeManagerCircle2, shapeManagerTriangle };

            foreach(ShapeManager item in shapeManagers)
            {
                item.Choice();
                item.Print();
                Console.WriteLine();
            }
        }
    }
}

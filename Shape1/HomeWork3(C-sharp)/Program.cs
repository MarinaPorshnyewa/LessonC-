using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Разработать абстрактный класс «Геометрическая Фигу-
ра» с методами «Площадь Фигуры» и «Периметр Фигуры».
Разработать классы-наследники: Треугольник, Квадрат,
Ромб, Прямоугольник, Параллелограмм, Трапеция, Круг,
Эллипс. Реализовать конструкторы, которые однозначно
определяют объекты данных классов.
Реализовать класс «Составная Фигура», который
может состоять из любого количества «Геометрических
Фигур». Для данного класса определить метод нахождения
площади фигуры. Создать диаграмму взаимоотношений
классов.
*/

namespace HomeWork3_C_sharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = {new Triangle(3,4,5),
            new Square(4),
            new Rhomb(6,3),
            new Circle(5)};
            foreach (Shape item in shape)
            {
                item.Perimeter();
                item.Area();
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Shape[] shape2 = { new Square(4), new Triangle(3, 4, 5), new Rhomb(6, 3) };
            CompoundShape compoundShape = new CompoundShape(shape2);
            compoundShape.AddPerimeter();
            compoundShape.Print();
        }
    }
}

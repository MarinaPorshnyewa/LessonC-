using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Разработать архитектуру классов иерархии товаров
при разработке системы управления потоками товаров для
дистрибьюторской компании. Прописать члены классов.
Создать диаграммы взаимоотношений классов.
Должны быть предусмотрены разные типы товаров,
в том числе:
• бытовая химия;
• продукты питания.
Предусмотреть классы управления потоком товаров
(пришло, реализовано, списано, передано).
*/

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = {new Food("agg", 2.45),
                new Food("milk", 1.3),
                new HouseholdChemicals("gel for washing dishes", 3.7),
                new HouseholdChemicals("shampoo", 5.5) };
            foreach(Product item in product)
            {
                Console.WriteLine(item);
            }

            

            Management[] management = {new Management(product[0]._name, Action.received),
                new Management(product[1]._name, Action.sold),
                new Management(product[2]._name, Action.transferred),
                new Management(product[3]._name, Action.written_off) };

            foreach (Management item in management)
            {
                item.Status();
            }
        }
    }
}

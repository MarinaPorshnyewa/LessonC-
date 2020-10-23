using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    //Задание из фото про постройку дома рабочими из частей
    //Получилась огромная((
    class Program
    {
        static void Main(string[] args)
        {
            Team[] team = {new TeamLeader("Anton",38),
            new Worker("Sergey",18), new Worker("Denis",25),
            new Worker("Oleg",26), new Worker("Leonid",20)};

            foreach (Team item in team)
            {
                item.TypeOfWorker();
                Console.WriteLine(item);
                Console.WriteLine();
            }
            bool boolCountWindow = true;
            int countWindow = 0;

            bool boolCountDoor = true;
            int countDoor = 0;

            bool boolCountBasement = true;
            int countBasement = 0;

            bool boolCountRoof = true;
            int countRoof = 0;

            bool boolCountWalls = true;
            int countWalls = 0;

            Console.WriteLine("Start build house! ");
            Console.WriteLine();
            do
            {
                if (boolCountBasement)
                {
                    Basement basement = new Basement();
                    basement.PartOfHouse();
                    countBasement++;
                }
                if (countBasement == 1)
                {
                    boolCountBasement = false;
                }

                Console.WriteLine($"Ready Window {countWindow}, Door {countDoor}," +
                    $" Basement {countBasement}, Roof {countRoof}, Walls {countWalls}");

            } while (boolCountBasement != false);

            Console.WriteLine();

            do
            {
                if (boolCountWalls)
                {
                    Walls walls = new Walls();
                    walls.PartOfHouse();
                    countWalls++;
                }
                if (countWalls == 4)
                {
                    boolCountWalls = false;
                }
                Console.WriteLine($"Ready Window {countWindow}, Door {countDoor}," +
                    $" Basement {countBasement}, Roof {countRoof}, Walls {countWalls}");

            } while (boolCountWalls != false);

            Console.WriteLine();

            do
            {
                if (boolCountRoof)
                {
                    Roof roof = new Roof();
                    roof.PartOfHouse();
                    countRoof++;
                }
                if (countRoof == 1)
                {
                    boolCountRoof = false;
                }
                Console.WriteLine($"Ready Window {countWindow}, Door {countDoor}," +
                    $" Basement {countBasement}, Roof {countRoof}, Walls {countWalls}");

            } while (boolCountRoof != false);

            Console.WriteLine();

            do
            {
                if (boolCountDoor)
                {
                    Door door = new Door();
                    door.PartOfHouse();
                    countDoor++;
                }
                if (countDoor == 1)
                {
                    boolCountDoor = false;
                }
                Console.WriteLine($"Ready Window {countWindow}, Door {countDoor}," +
                    $" Basement {countBasement}, Roof {countRoof}, Walls {countWalls}");

            } while (boolCountDoor != false);

            Console.WriteLine();

            do
            {
                if (boolCountWindow)
                {
                    Window window = new Window();
                    window.PartOfHouse();
                    countWindow++;
                }
                if (countWindow == 4)
                {
                    boolCountWindow = false;
                }
                Console.WriteLine($"Ready Window {countWindow}, Door {countDoor}," +
                    $" Basement {countBasement}, Roof {countRoof}, Walls {countWalls}");

            } while (boolCountWindow != false);

            Console.WriteLine();

            team[0].Report();
        }
    }
}

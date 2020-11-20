using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Игра автомобильные гонки с использованием
//делегатов и событий

namespace CarRacing
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> car = new List<Car>{
                new SportCar{_name = "name 1"},
                new Bus{_name ="name 2"}};

            Game game = new Game();

            foreach (var item in car)
            {
                game.startEvent += item.PositionStartCar;
                game.positionEvent += item.UpSpeed;
                game.winEvent += item.FinishCar;
                item.Win(game);
            }

            game.PositionStart();
            game.Move();
            game.Finish();
            Console.WriteLine("Победил " + game._winer);
        }
    }
}

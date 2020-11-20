using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    class SportCar : Car
    {
        public SportCar()
        {
            Random rnd = new Random();
            _speed = rnd.Next(100, 200);
        }
        public override void UpSpeed()
        {
            Console.WriteLine("Sportcar ");
            base.UpSpeed();
        }

        public override void FinishCar()
        {
            base.FinishCar();
        }

        public override void PositionStartCar()
        {
            base.PositionStartCar();
        }


    }

}

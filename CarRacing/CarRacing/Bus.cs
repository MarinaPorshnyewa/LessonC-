using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    class Bus:Car
    {
        public Bus()
        {
            Random rnd = new Random();
            _speed = rnd.Next(50, 150);
        }
        public override void UpSpeed()
        {
            Console.WriteLine("Bus ");
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

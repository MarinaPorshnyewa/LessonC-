using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
   
    public abstract class Car
    {
        public delegate void Winer(object _winer);

        public event Winer winerEvent;
        public string _name { get; set; }
        protected double _speed = 0;
        protected double metr = 0;
        

        public void Win(Game game)
        {
            winerEvent = game.onFinish;
        }
        public override string ToString()
        {
            return _name;
        }

        public virtual void UpSpeed()
        {
            Console.WriteLine("Car {0} drove {1} kilometers", _name, metr);
            metr += this._speed * 0.1;

            System.Threading.Thread.Sleep(500);

            if (metr >= 100)
                {              
                    winerEvent(this);                   
                }           
        }
        public virtual void FinishCar()
        {
            Console.WriteLine("Finish");
        }
        public virtual void PositionStartCar()
        {
            Console.WriteLine("Car {0} start, speed = {1}", _name, _speed);            
        }
    }
}

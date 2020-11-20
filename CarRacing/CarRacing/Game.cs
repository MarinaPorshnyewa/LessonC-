using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    public class Game
    {
        public delegate void Start();
        public delegate void Position();
        public delegate void Win();

        public event Start startEvent;
        public event Position positionEvent;
        public event Win winEvent;

        public bool startPosition = true;
        public object _winer;

        public void PositionStart()
        {
            if (startPosition)
            {
                startEvent();
                startPosition = false;
            }
        }
        public void Move()
        {              
                while(!startPosition)
                {
                    positionEvent();
                }                          
        }
        public void Finish()
        {
            if (startPosition)
            {
                winEvent();
            }
        }
        public void onFinish(object winer)
        {
            startPosition=true;
            _winer = winer;
        }


    }
}

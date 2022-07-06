﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fieldsandproperties
{
    internal class Car
    {
        private int speed;
        private int wheels;
        public string Color { get; set; }

        public int SpeedProperty
        {
            get { return speed; }
            set 
            { 
                if(value > 250)
                {
                    speed = 250;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public int WheelsProperty
        {
            get { return wheels; }
            set 
            {
                if(value > 4)
                {
                    wheels = 4;
                }
                else
                {
                    wheels = value;
                }
            }
        }
    }
}

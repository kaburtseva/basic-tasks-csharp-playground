﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    public abstract class Car
    {
        public int speed;
        int code;
        public Car(int speed)
        {
            this.speed = speed;
        }
        public abstract void Drive(int speed);

        public void Drive(int speed, int code)
        {

        }
    }
}
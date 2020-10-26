﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheNextCar.Model
{
    class Accubattery
    {
        private int voltage;
        private bool stateOn = false;

        public Accubattery(int voltage)
        {
            this.voltage = voltage;
        }

        public void turnOn()
        {
            this.stateOn = true;
        }

        public void turnOff()
        {
            this.stateOn = false;
        }

        public Boolean isOn()
        {
            return this.stateOn;
        }
    }
}

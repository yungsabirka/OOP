﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    abstract class GameObject
    {
        public int Saturability { get; set; }
        public Point Coordinate {get; set;}

        private int _priority;

    }
}
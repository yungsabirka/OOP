﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    abstract class ObjectWhoHasTarget : GameObject
    {
        public GameObject target;
        public int MaxSpeed { get; set; }
        public Point TargetMovement() 
        {
            Point newCoordinate = new Point();
            Point coordinateDifferences = new Point();

            coordinateDifferences.X = target.Coordinate.X - Coordinate.X;
            coordinateDifferences.Y = target.Coordinate.Y - Coordinate.Y;

            if (MaxSpeed < Math.Abs(coordinateDifferences.X))
                newCoordinate.X = MaxSpeed * Math.Sign(coordinateDifferences.X);
            else
                newCoordinate.X = coordinateDifferences.X;
            if (MaxSpeed < Math.Abs(coordinateDifferences.Y))
                newCoordinate.Y = MaxSpeed * Math.Sign(coordinateDifferences.Y);
            else
                newCoordinate.Y = coordinateDifferences.Y;

            newCoordinate += new Size(Coordinate.X, Coordinate.Y);

            return newCoordinate;
        }
    }
}

﻿using System;

namespace Methord
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point newLocation)
        {
            if(newLocation == null)
                throw new ArgumentException("new Location");
            
            Move(newLocation.x, newLocation.y);
         
        }
    }
}

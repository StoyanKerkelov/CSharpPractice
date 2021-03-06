﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefiningClassesPart2
{
    static class Points3DOperations
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double distance = 0;

            distance = Math.Sqrt((point2.XCoord - point1.XCoord) * (point2.XCoord - point1.XCoord) +
                (point2.YCoord - point1.YCoord) * (point2.YCoord - point1.YCoord) +
                (point2.ZCoord - point1.ZCoord) * (point2.ZCoord - point1.ZCoord));

            return distance;
        }
    }
}
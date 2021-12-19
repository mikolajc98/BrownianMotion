using System;
using System.Collections.Generic;

namespace BrownianMotionModel
{
    public class BrownPoint
    {
        private double _coordinateX;
        private double _coordinateY;

        public double X => _coordinateX;
        public double Y => _coordinateY;

        public BrownPoint()
        {
            this._coordinateX = BrownianMotionConsts.firstXcoordinate;
            this._coordinateY = BrownianMotionConsts.firstYcoordinate;
        }

        internal BrownPoint(double x, double y)
        {
            _coordinateX = x;
            _coordinateY = y;
        }

        public static List<BrownPoint> GenerateNPoints(int n)
        {
            if (n < 1)
                throw new ArgumentOutOfRangeException("Cannot generate less than 1 point!");

            var firstPoint = new BrownPoint();

            var result = new List<BrownPoint>(n)
            {
                firstPoint
            };

            Random rand = new Random();

            for (int i = 1; i < n; i++)
            {
                var nextPoint = GeneratePoint(result[i-1], rand);
                result.Add(nextPoint);
            }

            return result;
        }

        public static BrownPoint GeneratePoint(BrownPoint previousPoint, Random rand)
        {
            double newX = 0;
            double newY = 0;

            double fi = (rand.NextDouble()+1) * 2 * Math.PI;

            newX = Math.Round(previousPoint._coordinateX + Math.Cos(fi),BrownianMotionConsts.precision);
            newY = Math.Round(previousPoint._coordinateY + Math.Sin(fi),BrownianMotionConsts.precision);
            return new BrownPoint(newX,newY);
        }

        public override string ToString()
        {
            return $"({_coordinateX}, {_coordinateY})";
        }
    }
}

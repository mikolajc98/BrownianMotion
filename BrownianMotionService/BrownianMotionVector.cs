using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrownianMotionModel;

namespace BrownianMotionService
{
    public class BrownianMotionVector
    {
        public decimal CalculateVector(BrownPoint point)
        {
            if (point is null) throw new NullReferenceException("First point is null.");
            decimal vector = (decimal)Math.Sqrt(Math.Pow(point.X,2) + Math.Pow(point.Y,2));
            return Math.Round(vector,BrownianMotionConsts.precision);
        }
    }
}

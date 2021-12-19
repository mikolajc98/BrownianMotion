using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrownianMotionModel
{
    public class Result
    {
        private bool isError = true;
        public bool IsOk => !isError;

        private string _error;
        public string Error => _error;

        public static Result Ok()
        {
            return new Result()
            {
                isError = false,
                _error = "OK"
            };
        }

        public static Result Fail(string errorMessage)
        {
            return new Result()
            {
                isError = true,
                _error = errorMessage
            };
        }

        public override string ToString()
        {
            return Error;
        }

        public static bool operator ==(Result left, Result right)
        {
            return left.isError == right.isError;
        }

        public static bool operator !=(Result left, Result right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            Result right = (Result)obj;

            return this.isError == right.isError;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

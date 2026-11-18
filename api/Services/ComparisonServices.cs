using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class ComparisonServices : IComparisonServices
    {
        public string[] Comparison(int numThree, int numFour)
        {
            if (numThree > numFour)
            {
                return new string[]
                {
                    $"{numThree} is greater than {numFour}",
                    $"{numFour} is less than {numThree}"
                };
            }
            else if (numThree < numFour)
            {
                return new string[]
                {
                    $"{numThree} is less than {numFour}",
                    $"{numFour} is greater than {numThree}"
                };
            }
            else
            {
                return new string[]
                {
                $"{numThree} is equal to {numFour}",
                $"{numFour} is equal to {numThree}"
                };
            }
        }
    }
}
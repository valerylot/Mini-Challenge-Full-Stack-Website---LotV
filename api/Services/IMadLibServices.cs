using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IMadLibServices
    {
        string CreateMadLib(
            string madlib1,
            string madlib2,
            string madlib3,
            string madlib4,
            string madlib5,
            string madlib6,
            string madlib7,
            string madlib8,
            string madlib9,
            string madlib10);
    }
}
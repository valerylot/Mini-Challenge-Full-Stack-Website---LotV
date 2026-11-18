using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class SayHelloServices : ISayHelloServices
    {
        public string SayHello(string username)
        {
            return $"Hello {username}";
        }
    }
}
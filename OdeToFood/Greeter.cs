using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood
{
    public interface IGreeter
    {
        string GetGreeter();
    }
    public class Greeter : IGreeter
    {
        private string greeting;

        public Greeter(IConfiguration Configuration)
        {
            greeting = Configuration["greeting"];
        }
        public string GetGreeter()
        {
            return greeting;
        }
    }
}

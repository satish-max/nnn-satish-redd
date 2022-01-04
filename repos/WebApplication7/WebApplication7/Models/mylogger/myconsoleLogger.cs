using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models.mylogger
{
    public class myconsoleLogger :Ilog
    {
        public void info(string str)
        {
            Console.WriteLine(str);
        }
    }
}

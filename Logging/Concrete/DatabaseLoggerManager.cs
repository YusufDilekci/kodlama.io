using Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Concrete
{
    public class DatabaseLoggerManager : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message} logged to the DATABASE"); ;
        }
    }
}

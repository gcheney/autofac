using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConsoleApp
{
    public class MobileService : IMobileService
    {
        public void Execute()
        {
            Console.WriteLine("Sending a text.");
        }
    }
}

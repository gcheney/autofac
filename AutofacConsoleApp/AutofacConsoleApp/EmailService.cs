using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConsoleApp
{
    public class EmailService : IEmailService
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email.");
        }
    }
}

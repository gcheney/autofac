using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacConsoleApp
{
    public class NotificationSender
    {
        private readonly IMobileService _mobileService = null;
        public IEmailService _emailService = null;

        //Constructor injection
        public NotificationSender(IMobileService mobileService)
        {
            _mobileService = mobileService;
        }

        //Property injection 
        public IEmailService SetEmailService
        {
            set => _emailService = value;
        }

        public void SendNotification()
        {
            _mobileService.Execute();
            _emailService.Execute();
        }
    }

}

using System;
using Autofac;

namespace AutofacConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MobileService>().As<IMobileService>().SingleInstance();
            builder.RegisterType<EmailService>().As<IEmailService>().SingleInstance();
            var container = builder.Build();

            var notificationSender = new NotificationSender(container.Resolve<IMobileService>())
            {
                SetEmailService = container.Resolve<IEmailService>()
            };

            notificationSender.SendNotification();
            Console.ReadLine();
        }
    }
}

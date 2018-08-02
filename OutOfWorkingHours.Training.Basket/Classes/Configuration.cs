using OutOfWorkingHours.Training.Basket.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutOfWorkingHours.Training.Basket.Classes
{
    public class Configuration : IConfiguration
    {
        public IDatabaseconfiguration DatabaseConfiguration { get; set; } = new Databaseconfiguration();
        public ISmtpconfiguration SmtpConfiguration { get; set; } = new Smtpconfiguration();
    }
    
    public interface IConfiguration
    {
        IDatabaseconfiguration DatabaseConfiguration { get; set; }
        ISmtpconfiguration SmtpConfiguration { get; set; }
    }

    public interface ISmtpconfiguration
    {
        string HostName { get; set; }
        string Port { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
    }

    public interface IDatabaseconfiguration
    {
        string ConnectionString { get; set; }
    }

  
    public class Databaseconfiguration : IDatabaseconfiguration
    {
        public string ConnectionString { get; set; }
    }


    public class Smtpconfiguration : ISmtpconfiguration
    {
        public string HostName { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

}

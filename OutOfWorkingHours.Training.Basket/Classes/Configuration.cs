using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutOfWorkingHours.Training.Basket.Classes
{

    public class Configuration
    {    
        public Databaseconfiguration DatabaseConfiguration { get; set; }
        public Smtpconfiguration SmtpConfiguration { get; set; }
    }

    public class Databaseconfiguration
    {
        public string ConnectionString { get; set; }
    }

    public class Smtpconfiguration
    {
        public string HostName { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

}

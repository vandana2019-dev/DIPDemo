using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _messageSender;
        public string ChromeName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; private set; }

        // In the constructor, we passed two interfaces
        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        // use the interface instances to Log and send message
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChromeName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            
            _logger.Log($"Completed { ChromeName }");
           
            _messageSender.SendMessage(Owner, $"The chore { ChromeName } is complete");
        }
    }

}

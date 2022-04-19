using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Old
{
    public class ChoreOld
    {
        public string ChromeName { get; set; }
        public PersonOld Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            LoggerOld logger = new LoggerOld();
            logger.Log($"Performed work on { ChromeName }");
            
        }

        public void CompleteChore()
        {
            IsComplete = true;

            LoggerOld logger = new LoggerOld();
            logger.Log($"Completed { ChromeName }");

            EmailerOld emailer = new EmailerOld();
            emailer.SendEmail(Owner, $"The chore { ChromeName } is complete");
        }
    }
        
}

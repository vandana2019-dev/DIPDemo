namespace DemoLibrary
{
    public interface IChore
    {
        string ChromeName { get; set; }
        double HoursWorked { get; set; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }
}
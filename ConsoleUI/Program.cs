// See https://aka.ms/new-console-template for more information
using DemoLibrary.Old;
using DemoLibrary;
using ConsoleUI;

Console.WriteLine("Hello, World!");

PersonOld ownerOld = new PersonOld
{
    FirstName = "Tim",
    LastName = "Corey",
    EmailAddress = "tim@iamtimcorey.com",
    PhoneNumber = "555-1212"
};


ChoreOld choreOld = new ChoreOld
{
    ChromeName = "Take out the trash",
    Owner = ownerOld
};

choreOld.PerformedWork(3);
choreOld.PerformedWork(1.5);
choreOld.CompleteChore();

Console.WriteLine("Hello, World!- Dependency Inversion Principle");

// We need to keep the Dependency on Interface and keep the dependency on the Class (creating an object)

//IPerson owner = new Person
//{
//    FirstName = "Tim",
//    LastName = "Corey",
//    EmailAddress = "tim@iamtimcorey.com",
//    PhoneNumber = "555-1212"
//};


//Chore chore = new Chore
//{
//    ChromeName = "Take out the trash",
//    Owner = owner
//};

//chore.PerformedWork(3);
//chore.PerformedWork(1.5);
//chore.CompleteChore();


Console.WriteLine("Dependency Inversion");

// Instead of using the above, using the Dependency Inversion and use the place from where the classes are created
IPerson owner3 = Factory.CreatePerson();
owner3.FirstName = "Tim";
owner3.LastName = "Corey";
owner3.EmailAddress = "tim@iamtimcorey.com";
owner3.PhoneNumber = "555-1212";

IChore chore3 =  Factory.CreateChore();
chore3.ChromeName = "Take out the trash";
chore3.Owner = owner3;


chore3.PerformedWork(3);
chore3.PerformedWork(1.5);
chore3.CompleteChore();

Console.ReadLine();

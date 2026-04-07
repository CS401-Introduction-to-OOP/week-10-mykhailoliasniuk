namespace ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        var eventLog = new EventLog();
        var party = new Party();
        while (true)
        {
            Console.WriteLine("stop/create/make action");
            string uinp = Console.ReadLine();
            if (uinp == "stop")
            {
                break;
            }

            if (uinp == "create")
            {
                Console.WriteLine("Person/Ivent");
                string uinp3 = Console.ReadLine();
                if (uinp3 == "Person")
                {
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter health:");
                    int health = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter gold:");
                    double gold = double.Parse(Console.ReadLine());

                    Person p = new Person(name, health, gold);
                    party.Add(p);

                    Console.WriteLine("Person created");
                }

                if (uinp3 == "Ivent")
                {
                    Console.WriteLine("Enter number:");
                    int number = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter description:");
                    string description = Console.ReadLine();

                    Console.WriteLine("Enter type:");
                    string type = Console.ReadLine();

                    Ivent e = new Ivent(number, description, type);
                    eventLog.Add(e);

                    Console.WriteLine("Event created");
                }
            }

            if (uinp == "make action")
            {
                Console.WriteLine("show active/show persons/show events/show max gold");
                string uinp2 = Console.ReadLine();
                if (uinp2 == "show active")
                {
                    foreach (var p in party.ReturnActive()) {}
                }

                if (uinp2 == "show persons")
                {
                    foreach(var p in party.ReturnAll()){}
                }

                if (uinp2 == "show events")
                {
                    foreach (var e in eventLog.KhronologicalOrder()) {}
                }

                if (uinp2 == "show max gold")
                {
                    party.MaxGold();
                }
            }
            
        }
    }
}
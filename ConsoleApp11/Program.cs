namespace ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
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
                string uinp2 = Console.ReadLine();
                if (uinp2 == "Person")
                {
                    string uinpPerson = Console.ReadLine(); ;
                }
            }
        }
    }
}
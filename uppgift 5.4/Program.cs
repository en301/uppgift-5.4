using System;

namespace uppgfit_5_4
{
    class Program
    {
        static void Main()
        {
            string[] namn = { "Anna", "David", "Eva", "Bengt", "Cecilia" };
            Array.Sort(namn);
            Console.WriteLine("Namn i bokstavsordning:");
            foreach (string namnskriv in namn)
            {
                Console.WriteLine(namnskriv);
            }
        }
    }
}

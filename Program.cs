using System;

namespace quiz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleases input number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", number);
            int[] num = new int[number];
            for(int i = 0; i < number; i++) {

            Console.Write("Pleases input nameitem");
                        string nameitem;

            nameitem = Console.ReadLine();

            Console.WriteLine("Nameitem: {0}", nameitem);

            Console.Write("Pleases input type");
            string type;

            type = Console.ReadLine();

            Console.WriteLine("Type: {0}", type); 
            }

        }
    }
}

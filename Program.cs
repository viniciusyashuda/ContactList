using System;

namespace ContactsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            int option;

            do
            {

                Console.WriteLine("\n*********** (MENU) ***********\n");
                Console.WriteLine("   Choose an action:");
                Console.WriteLine("   1- Insert a contact");
                Console.WriteLine("   2- Print the contacts list");
                Console.WriteLine("   3- Remove a contact");
                Console.WriteLine("   4- Search for a contact");
                Console.WriteLine("   5- Edit a contact");
                Console.WriteLine("   6- Leave");
                Console.WriteLine("\n******************************\n");



                Console.Write("Option: "); option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Console.Clear();
                        list.Insert();
                        break;
                    case 2:
                        Console.Clear();
                        list.Print();
                        break;
                    case 3:
                        Console.Clear();
                        list.Remove();
                        break;
                    case 4:
                        Console.Clear();
                        list.Search();
                        break;
                    case 5:
                        Console.Clear();
                        list.Edit();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Please, enter a valid option!");
                        break;
                }

            }

            while (option != 6);
            Console.ReadKey();

        }
    }
}

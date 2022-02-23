using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Comparison
{
    LessThan = -1, Equal = 0, GreaterThan = 1
};

namespace ContactsList
{
    internal class List
    {

        public Contacts Head { get; set; }
        public Contacts Tail { get; set; }



        public List()
        {
            Head = null;
            Tail = null;
        }

        public bool Empty()
        {
            if ((Head == null) && (Tail == null))
                return true;
            else
                return false;
        }

        public Contacts Insert()
        {

            PhoneList phonelist = new PhoneList();
            Contacts aux;
            string name, email, type, phonenumber;
            int ddd;
            int opt;


            Console.Write("\n     Enter the contact's name: "); name = Console.ReadLine();

            Console.Write("\n\n     Enter the contact's email: "); email = Console.ReadLine();


            do
            {
                Console.Write("\n\n     Enter the contact's phone type: "); type = Console.ReadLine();

                Console.Write("\n\n    Enter the contact's phone DDD: "); ddd = int.Parse(Console.ReadLine());

                Console.Write("\n\n     Enter the contact's phone number: "); phonenumber = Console.ReadLine();

                phonelist.InsertPhone(new Phone(type, ddd, phonenumber));

                Console.Clear();

                Console.WriteLine("\n\n     Do you want to add one more phone number?\n     1- Yes or 2- No");

                Console.Write("\n     Option: "); opt = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (opt == 1);

            aux = new Contacts(name, email, phonelist);

            Sort(aux);

            Console.Clear();

            return aux;

        }

        public void Print()
        {
            Contacts aux = Head;

            if (Empty())
            {
                Console.WriteLine("There are no contacts in the list!!");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Next;
                    Console.ReadKey();
                }
                while (aux != null);
            }
            Console.Clear();
        }

        public Contacts Search()
        {
            Contacts aux = Head;
            string search;
            int count = 0;

            if (Empty())
            {
                Console.WriteLine("\n     Could not find any contact because there are no contacts in the list!!\n");
                Console.ReadKey();
            }
            else
            {

                Console.WriteLine("\n     Enter the name you want to search: ");
                Console.Write("\n     Search for: "); search = Console.ReadLine();

                do
                {

                    if (aux.Name.ToUpper().CompareTo(search.ToUpper()) == 0)
                    {
                        Console.WriteLine(aux.ToString());
                        count++;
                        Console.ReadKey();
                    }
                    aux = aux.Next;

                }
                while (aux != null);

                if (count == 0)
                {
                    Console.WriteLine("\n     Could not find any contact with this name!\n");
                    Console.ReadKey();
                }

            }
            return aux; 
            Console.Clear();
        }

        public void Remove()
        {
            Contacts aux = Head;
            Contacts aux1 = Head;
            Contacts aux2 = Head;

            string search;
            int count = 0, answer, counter = 0;

            if (Empty())
            {
                Console.WriteLine("\n     Could not find any contact because there are no contacts in the list!!\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\n     Enter the name you want to search: ");
                Console.Write("\n     Search for: "); search = Console.ReadLine();

                do
                {
                    if (search.ToUpper() == aux.Name.ToUpper())
                    {
                        if (count == 0)
                        {
                            aux2 = aux;
                        }
                        count++;
                    }

                    aux = aux.Next;

                } while (aux != null);

                if (count == 0)
                {

                    Console.WriteLine("\n     Could not find any contact with this name!\n");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (count == 1)
                {
                    aux = Head;

                    if (search.ToUpper().CompareTo(Head.Name.ToUpper()) == 0)
                    {
                        Head = aux.Next;

                        if (Head == null)
                        {
                            Tail = null;
                        }

                        Console.WriteLine("\n     The contact has been successfully removed!\n");
                        Console.ReadKey();
                        Console.Clear();

                    }

                    else
                    {
                        aux = aux.Next;

                        do
                        {
                            if (search.ToUpper().CompareTo(aux.Name.ToUpper()) == 0)
                            {
                                if (search.ToUpper().CompareTo(Tail.Name.ToUpper()) == 0)
                                {
                                    aux1.Next = aux.Next;
                                    Tail = aux1;
                                }
                                else
                                {
                                    aux1.Next = aux.Next;
                                }
                            }

                            aux1 = aux1.Next;
                            aux = aux.Next;

                        }
                        while (aux != null);

                        Console.WriteLine("\n     The contact has been successfully removed!\n");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {

                    Console.WriteLine("\n     Contacts found:");

                    aux = Head;

                    do
                    {
                        if (aux.Name.ToUpper().CompareTo(search.ToUpper()) == 0)
                        {
                            Console.WriteLine(aux.ToString());
                        }
                        aux = aux.Next;

                    }
                    while (aux != null);

                    if (aux2.Name.ToUpper().CompareTo(search.ToUpper()) == 0)
                    {

                        do
                        {
                            Console.WriteLine("\n     Is this the contact you want to remove?");
                            Console.WriteLine(aux2.ToString());
                            Console.WriteLine("\n     1- Yes or 2- No");
                            Console.Write("\n     Option: "); answer = int.Parse(Console.ReadLine());

                            for (aux1 = Head; aux1.Next != aux2;)
                            {
                                aux1 = aux1.Next;
                            }

                            if (answer == 1)
                            {

                                if (aux2.Name.ToUpper().CompareTo(Head.Name.ToUpper()) == 0 && counter == 0)
                                {
                                    Head = aux2.Next;

                                    if (Head == null)
                                    {
                                        Tail = null;
                                    }

                                    Console.WriteLine("\n     The contact has been successfully removed!\n");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }

                                else
                                {

                                    do
                                    {

                                        counter++;
                                        if (search.ToUpper().CompareTo(Tail.Name.ToUpper()) == 0 && counter == count)
                                        {
                                            aux1.Next = aux2.Next;
                                            Tail = aux1;
                                            break;
                                        }
                                        else if (search.ToUpper().CompareTo(aux2.Name.ToUpper()) == 0)
                                        {
                                            aux1.Next = aux2.Next;
                                            break;
                                        }


                                        aux1 = aux1.Next;
                                        aux2 = aux2.Next;

                                    }
                                    while (aux2 != null);

                                    Console.WriteLine("\n     The contact has been successfully removed!\n");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }

                            }
                            else if (answer == 2)
                            {
                                counter++;
                                if (counter < count)
                                {
                                    aux2 = aux2.Next;
                                    aux1 = aux1.Next;
                                }
                                else
                                    break;

                            }
                            else
                            {
                                break;
                            }
                        }
                        while (answer != 1);
                    }
                }
            }
        }

        public void Edit()
        {
            if (!Empty())
            {

                Remove();
                Console.Clear();
                Console.WriteLine("\n      Starting the edition...\n");
                Insert();
            }
            else
            {
                Console.WriteLine("\n     Could not find any contact because there are no contacts in the list!!\n");
                Console.Clear();
            }
        }

        public void Sort(Contacts aux)
        {
            Contacts aux1 = Head;
            Contacts aux2 = Head;

            if (Empty())
            {
                Head = aux;
                Tail = aux;
            }

            else if ((aux.Name.CompareTo(Tail.Name) == 1) || (aux.Name.CompareTo(Tail.Name) == 0))
            {
                Tail.Next = aux;
                Tail = aux;
            }

            else if ((aux.Name.CompareTo(Head.Name) == -1) || (aux.Name.CompareTo(Head.Name) == 0))
            {
                aux.Next = Head;
                Head = aux;
            }

            else
            {
                aux1 = aux1.Next;
                int count = 0;
                do
                {
                    if (aux1.Name.CompareTo(aux.Name) == 1)
                    {

                        if (count == 0)
                        {
                            aux2.Next = aux;
                            aux.Next = aux1;
                            count++;
                            //break;
                        }

                    }

                    aux2 = aux2.Next;
                    aux1 = aux1.Next;

                }

                while (aux1 != null);



            }
        }
    }
}

using System;

namespace ContactsList
{
    internal class PhoneList
    {
        public Phone Start { get; set; }
        public Phone End { get; set; }
        public Phone Next{ get; set; }

        public PhoneList()
        {
            Start = null;
            End = null;
            Next = null;
        }

        public void InsertPhone(Phone auxiliar)
        {
            if(Start == null && End == null)
            {
                Start = auxiliar;
                End = auxiliar;
            }
            else
            {
                End.Next = auxiliar;
                End = auxiliar;
            }
        }

        public string PrintPhone()
        {
            int counter1 = 0;
            string phone = "";
            Phone aux3 = Start;
            do
            {
                counter1++;
                phone = phone +"\n"+ aux3.ToString();
                aux3 = aux3.Next;
                
            } while (aux3 != null);
            return phone;
        }

        


    }
}

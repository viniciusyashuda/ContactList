using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsList
{
    internal class Contacts
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public PhoneList Phone { get; set; }
        public Contacts Next { get; set; }

        public Contacts(string name, string email, PhoneList phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Next = null;
        }

        public override string ToString()
        {
            return $"\n      [Contact]       \n\n  Name: {Name}\n\n  E-mail: {Email}\n\n  Phone(s):\n {Phone.PrintPhone()}\n";
        }
    }
}

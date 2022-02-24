using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsList
{
    internal class Phone
    {
        public string Type { get; set; }
        public int DDD { get; set; }
        public string Number { get; set; }
        public Phone Next { get; set; }
        //test git
        public Phone(string type, int ddd, string number)
        {
            Type = type;
            DDD = ddd;
            Number = number;
            Next = null;
        }

        public override string ToString()
        {
            return $"  {Type}:\n\n   ({DDD}) {Number}\n";
        }
    }
}

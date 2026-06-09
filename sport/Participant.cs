using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport
{
    public class Participant
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }


        public Participant(string name, int age, string phone)
        {
            Name = name;
            Age = age;
            PhoneNumber = phone;
        }
    }
}

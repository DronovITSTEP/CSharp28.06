using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp28._06
{
    //[Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        int _ID;

        [NonSerialized]
        const string Planet = "Earth";

        public Person() { }
        public Person (int num)
        {
            _ID = num;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, ID: {_ID}, Planet: {Planet}";
        }
    }
}

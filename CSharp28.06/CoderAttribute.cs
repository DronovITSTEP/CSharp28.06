using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp28._06
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Method)]
    internal class CoderAttribute : Attribute
    {
        string _name = "Dronov";
        DateTime _date = DateTime.Now;

        public CoderAttribute() { }
        public CoderAttribute(string name, string date)
        {
            try
            {
                _name = name;
                _date = Convert.ToDateTime(date);
            }
            catch (Exception e) { }
        }
        public override string ToString()
        {
            return $"Разработчик: {_name}, Дата: {_date}";
        }
    }

    [Coder]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        [Coder("Sergey", "2023-06-22")]
        public void IncreaseWages(double wage)
        {
            Salary += wage;
        }
    }
}

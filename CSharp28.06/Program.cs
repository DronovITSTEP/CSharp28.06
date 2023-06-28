using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace CSharp28._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string emailPattern = @"^[0-9]{1}([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            string phonePattern = @"^\+\d{1}\(\d{3}\)\d{3}-\d{2}-\d{2}$"; // +7(111)666-55-88

            // email@ya.ru
            // qwert234@gmail.com
            // eret@fff
            // trtrt.rtr
            string email = Console.ReadLine();
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(regex.IsMatch(email) ? "мыло введено верно" : "неверно");
            regex = new Regex(phonePattern);
            string phone = Console.ReadLine();
            Console.WriteLine(regex.IsMatch(phone) ? "телефон введено верно" : "неверно");*/

            //CLR, метаданные, CIL

            /*foreach (var attr in typeof(Employee).GetCustomAttributes(true))
            {
                Console.WriteLine(attr);
            }

            Console.WriteLine("\n");

            foreach (var item in typeof(Employee).GetMembers())
            {
                foreach (var attr in item.GetCustomAttributes(true))
                {
                    Console.WriteLine(attr);
                }
            }*/


            Person person = new Person(584848) { Name = "Ivan", Age = 35 };

            /*BinaryFormatter bf = new BinaryFormatter();

            try
            {
                using (Stream fStream = File.Create("test.bin"))
                {
                    bf.Serialize(fStream, person);
                }
                Console.WriteLine("It's OK!");

                Person person1 = null;

                using (Stream fStream = File.OpenRead("test.bin"))
                {
                    person1 = (Person)bf.Deserialize(fStream);
                }
                Console.WriteLine(person1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            try
            {
                using (Stream fStream = File.Create("test.xml"))
                {
                    serializer.Serialize(fStream, person);
                }
                Console.WriteLine("It's OK!");

                Person person1 = null;

                using (Stream fStream = File.OpenRead("test.xml"))
                {
                    person1 = (Person)serializer.Deserialize(fStream);
                }
                Console.WriteLine(person1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

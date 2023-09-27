using System.Threading.Channels;
using System.Xml;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = GetPersons().ToArray();

            var allPersonsOver20 = persons.Where(p => p.Age > 20).Select(p => p.Name);
            var allPersonsOver202 = persons.Where(IsOver20);

            var allPersonsOver30 = persons.OuersWhere(p => p.Age > 30);
            var allPersonsOver302 = persons.OuersWhere(IsOver20);
                

            foreach ( var person in allPersonsOver30)
            {
                Console.WriteLine(person);
            }

            var ages = persons.Where(p => p.Name == "Pelle")
                              .Select(p => p.Age)
                              .Sum();

            IEnumerable<PersonDto> dtos = persons.Where(p => p.Name == "Pelle")
                              .Select(p => new PersonDto
                              {
                                  Name = p.Name,
                                  NamesLength = p.Name.Length
                              });


            var persons2 = GetPersons().ToList();

            persons2.ForEach(person => Console.WriteLine(person));
            persons2.ForEach(Console.WriteLine);
            persons2.ForEach(Test);

        }


        private static bool IsOver20(Person person)
        {
            return person.Age > 20;
        }  
        
        private static void Test(Person person)
        {
            Console.WriteLine(person);
        }

        private static List<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa",   45),
                new("Sophia-Magdalena", 32),
            };
        }
    }
}
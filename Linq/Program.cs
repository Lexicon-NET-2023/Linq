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
        }


        private static bool IsOver20(Person person)
        {
            return person.Age > 20;
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
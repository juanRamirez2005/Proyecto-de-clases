using Main;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> initialPeople = new List<Person>
            {
                new Person("Juan Camilo", 18),
                new Person("Hector Andres", 34),
                new Person("Sandra Milena", 40)
            };

            People myclass = new People(initialPeople);

            foreach(Person person in initialPeople) 
            {
                Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
            }
        }
    }
}
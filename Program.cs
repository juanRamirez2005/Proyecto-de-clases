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
                new Person("Sandra Milena", 40),
                new Person("Luisa Maria", 14),
                new Person("Daniel", 14),
                new Person("Santiago", 19),
                new Person("Pablo", 12),
            };

            People myclass = new People(initialPeople);

            foreach (Person person in initialPeople)
            {
                Console.WriteLine("Name: " + person.Name + " |Age: " + person.Age + (person.Age > 18? " --This person is an Adult": " --This person is Underage"));
            }
        }
    }
}
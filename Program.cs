namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Would you like to Sing up? yes/no");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                try
                {
                    Console.WriteLine("Introduce your name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Now introduce your age");
                    int age = Int32.Parse(Console.ReadLine());

                    Person person1 = new Person(name, age);
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
            else 
            {
                Console.WriteLine("Thanks for comming!!");
            }
        }
    }
}
namespace Polymorphism
{
    class Person
    {
        public virtual void Work()
        {
            Console.WriteLine("Working...");
        }
    }

    class Driver : Person
    {
        public override void Work()
        {
            Console.WriteLine("Driving...");
        }
    }

    class Teacher : Person
    {
        public override void Work()
        {
            Console.WriteLine("Teaching...");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new();
            person.Work();

            Person driver = new Driver();
            driver.Work();

            Person teacher = new Teacher();
            teacher.Work();
        }
    }
}
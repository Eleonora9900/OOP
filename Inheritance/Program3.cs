namespace Inheritance
{
    class Animal
    {
        protected string name = String.Empty;

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty!");
                    return;
                }
                name = value;
            }
        }

        public Animal(string name)
        {
            Name = name;
        }
    }

    class Dog : Animal
    {
        public int age;

        public Dog(string name, int _age) : base(name)
        {
            age = _age;
        }
    }


    class Program
    {
        static void Main()
        {
            Dog dog = new("Jack", 3);
            Console.WriteLine(dog.Name);
        }
    }
}
namespace Interface
{
    interface IAnimal
    {
        void MakeSound();
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("bark...");
        }
    }

    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow...");
        }
    }

    class Program
    {
        static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static double Sum(double fisrtNum, double secondNum, double ThirdNum)
        {
            return fisrtNum + secondNum + ThirdNum;
        }

        static void Main()
        {
            Cat cat = new();
            Dog dog = new();

            cat.MakeSound();
            dog.MakeSound();

            int result = Sum(3, 4);
            double value = Sum(5.5, 2.2, 3.8);

            Console.WriteLine($"Int result: {result}, Double result: {value}");
        }
    }
}
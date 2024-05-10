namespace Encapsulation
{
    class Player
    {
        private string name = String.Empty;
        public int _age;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 3 || String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name must be at least three characters and not empty!");
                    return;
                }
                name = value;
            }
        }

        public Player(string name, int age)
        {
            Name = name;
            _age = age;
        }
    }




    class Program
    {
        static void Main()
        {
            Player player = new("Eli", 24);
            Console.WriteLine(player.Name);
            Console.WriteLine(player._age);
        }
    }
}
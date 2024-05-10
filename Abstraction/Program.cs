namespace Abstraction
{
    abstract class Vehicle
    {
        public double _fuelConsumption;
        public double _fuelQuantity;

        public Vehicle(double fuelConsumption, double quantity)
        {
            _fuelConsumption = fuelConsumption;
            _fuelQuantity = quantity;
        }

        abstract public void Drive(double distance);

        abstract public void Refuel(double fuel);
    }

    class Car : Vehicle
    {
        public Car(double _fuelConsumption, double _fuelQuantity) : base(_fuelConsumption, _fuelQuantity)
        {

        }

        public override void Drive(double distance)
        {
            if (_fuelQuantity / _fuelConsumption >= distance)
            {
                _fuelQuantity -= _fuelConsumption * distance;
            }
        }

        public override void Refuel(double fuel)
        {
            _fuelQuantity += fuel;
        }
    }

    class Program
    {
        static void Main()
        {
            Car car = new(6, 50.5);
            car.Drive(5);
            Console.WriteLine(car._fuelQuantity);

            car.Refuel(10);
            Console.WriteLine(car._fuelQuantity);


        }
    }
}
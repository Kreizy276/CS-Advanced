namespace CarEngineAndTires
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new(220, 3000);
            Tire[] tires = new Tire[4]
            {
                new Tire(2006, 2.2),
                new Tire(2007, 2.2),
                new Tire(2008, 2.4),
                new Tire(2009, 2.4),
            };

            Car car = new Car("BMW", "M3", 2006, 60, 15, engine, tires);

            Console.WriteLine(car.Engine.HorsePower);
            Console.WriteLine(car.Tires[3].Year);
        }
    }
}

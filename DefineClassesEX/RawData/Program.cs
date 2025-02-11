namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> listOfCars = new();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = data[0];
                int engineSpeed = int.Parse(data[1]),
                    enginePower = int.Parse(data[2]),
                    cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tires[] tires = new Tires[]
                {
                    new Tires(double.Parse(data[5]), int.Parse(data[6])),
                    new Tires(double.Parse(data[7]), int.Parse(data[8])),
                    new Tires(double.Parse(data[9]), int.Parse(data[10])),
                    new Tires(double.Parse(data[11]), int.Parse(data[12])),
                };

                Car car = new Car(model, engine, cargo, tires);
                listOfCars.Add(car);
            }

            string command = Console.ReadLine();

            Func<Car, bool>? filter = command switch
            {
                "fragile" => filter = x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1),
                "flammable" => filter = z => z.Cargo.Type == "flammable" && z.Engine.HorsePower > 250,
                _ => throw new InvalidOperationException("Invalid command")
            };

            foreach(Car car in listOfCars.Where(filter)) Console.WriteLine(car.Model);
        }
    }
}

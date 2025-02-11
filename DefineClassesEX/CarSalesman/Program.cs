namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> listOfEngines = new();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                int power = int.Parse(data[1]);

                Engine engine;
                if (data.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (data.Length == 3)
                {
                    if (int.TryParse(data[2], out int displacement))
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, null, data[2]);
                    }
                }
                else
                {
                    int displacement = int.Parse(data[2]);
                    string efficiency = data[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }

                listOfEngines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new();
            for(int i = 0; i < m; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                string engineModel = data[1];

                Engine engine = listOfEngines.Find(x => x.Model == engineModel);
                Car car;
                if (data.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (data.Length == 3)
                {
                    if (int.TryParse(data[2], out int weight))
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, null, data[2]);
                    }
                }
                else
                {
                    int weight = int.Parse(data[2]);
                    string color = data[3];
                    car = new Car(model, engine, weight, color);
                }
                listOfCars.Add(car);
            }

            foreach(Car car in listOfCars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {(car.Engine.Displacement.HasValue ? car.Engine.Displacement.ToString() : "n/a")}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {(car.Weight.HasValue ? car.Weight.ToString() : "n/a")}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
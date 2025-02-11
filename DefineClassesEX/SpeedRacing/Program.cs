namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Car> carsByModel = new();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumptionFor1km = double.Parse(data[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                carsByModel[model] = car;
            }

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (data[0] != "Drive") continue;

                string model = data[1];
                double distance = double.Parse(data[2]);

                Car car = carsByModel[model];

                if (!car.Drive(distance))
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }

            foreach(Car car in carsByModel.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}

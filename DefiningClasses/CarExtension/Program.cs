namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "VW",
                Model = "MK3",
                Year = 1992,
                FuelQuantity = 200,
                FuelConsuption = 200,
            };

            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
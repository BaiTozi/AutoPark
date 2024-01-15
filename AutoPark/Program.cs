using AutoPark2.Data;

namespace AutoPark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Autopark autopark = new Autopark();

            // Adding users, brands, models, and cars
            autopark.Users.Add(new User { ID = 1, FirstName = "John", LastName = "Doe" });

            autopark.Brands.Add(new Brand { ID = 1, Name = "Toyota" });
            autopark.Brands.Add(new Brand { ID = 2, Name = "Ford" });

            autopark.Models.Add(new Model { ID = 1, Name = "Corolla", ModelID = 1, ModelName = "Sedan" });
            autopark.Models.Add(new Model { ID = 2, Name = "Camry", ModelID = 2, ModelName = "Sedan" });

            autopark.Cars.Add(new Car { CarID = 1, ModelID = 1, Year = 2022 });
            autopark.Cars.Add(new Car { CarID = 2, ModelID = 2, Year = 2023 });

            // Sorting cars by brand
            var sortedCarsByBrand = from car in autopark.Cars
                                    join model in autopark.Models on car.ModelID equals model.ModelID
                                    join brand in autopark.Brands on model.ID equals brand.ID
                                    orderby brand.Name
                                    select new
                                    {
                                        CarID = car.CarID,
                                        Brand = brand.Name,
                                        Model = model.ModelName,
                                        Year = car.Year
                                    };

            // Displaying sorted cars by brand
            Console.WriteLine("Sorted Cars by Brand:");
            foreach (var car in sortedCarsByBrand)
            {
                Console.WriteLine($"CarID: {car.CarID}, Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}");
            }
        }
    }
}
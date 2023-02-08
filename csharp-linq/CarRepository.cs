namespace csharp_linq
{
	internal class CarRepository
	{
		public IEnumerable<Car> GetCars()
		{
			return new List<Car>()
			{
				new Car() { Name = "Tesla Model S", Price = 96630m },
				new Car() { Name = "Ferrari 812 Superfast", Price = 335000 },
				new Car() { Name = "Lamborghini Aventador", Price = 507353 },
				new Car() { Name = "Mercedes-Benz GLB", Price = 384900 },
				new Car() { Name = "Porshce 911", Price = 769000 },
				new Car() { Name = "Porshce 911", Price = 720000 }
			};
		}
	}
}

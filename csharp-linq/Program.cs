using csharp_linq;

var cars = new CarRepository().GetCars();

// LINQ Extension Methods
var cheapCars = cars
	.Where(p => p.Price < 400000)
	.OrderBy(p => p.Name)
	.Select(p => p.Name);
foreach(var car in cheapCars)
{
	Console.WriteLine(car);
}


// LINQ Query Operators
var cheaperCars =
	from c in cars
	where c.Price < 400000
	orderby c.Name
	select c.Name;
foreach(var car in cheaperCars)
{
	Console.WriteLine(car);
}

var mCar = cars.Single(p => p.Name == "Ferrari 812 Superfast");
Console.WriteLine(mCar.Name);

mCar = cars.SingleOrDefault(p => p.Name == "Ferrari F40");
Console.WriteLine(mCar == null);

mCar = cars.First(p => p.Name == "Porshce 911");
Console.WriteLine($"{mCar.Name} - {mCar.Price}");

mCar = cars.Last(p => p.Name == "Porshce 911");
Console.WriteLine($"{mCar.Name} - {mCar.Price}");

mCar = cars.FirstOrDefault(p => p.Name == "Porshce Carrera GT");
Console.WriteLine($"{mCar?.Name} - {mCar?.Price}");

// use to paginate
var pagedCars = cars.Skip(2).Take(3);
foreach (var pagedCar in pagedCars)
{
	Console.WriteLine($"{pagedCar.Name} - {pagedCar.Price}");
}

var count = cars.Count();
Console.WriteLine(count);

var maxPrice = cars.Max(p => p.Price);
var minPrice = cars.Min(p => p.Price);

Console.WriteLine(maxPrice);
Console.WriteLine(minPrice);

var totalPrices = cars.Sum(p => p.Price);
Console.WriteLine(totalPrices);

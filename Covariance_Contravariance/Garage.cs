using Bogus;

namespace Covariance_Contravariance;

 class Garage : IGarage<Car>
{
	private List<Car> _cars;
	public Garage()
	{
		var id = 1;
		var faker = new Faker<Car>();

		_cars = faker.RuleFor(x => x.Id, x => id++).Generate(5);
	}
	public Car GetVehicle(int id)
	{
		return _cars.Find(x => x.Id == id) ?? throw new KeyNotFoundException();
	}
}
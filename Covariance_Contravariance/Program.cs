using Covariance_Contravariance;

IGarage<Vehicle> garage = new Garage();

IVehicleCollection<Car> collection = new VehicleCollection();

Foo(new Garage());

Action<object> x = s =>
{
	Console.WriteLine(s);
};

Bar(x);

void Foo(IGarage<Vehicle> garage)
{
	
}

void Bar(Action<string> x)
{
	
}



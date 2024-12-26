namespace Covariance_Contravariance;

interface IVehicleCollection<in T>
	where T : Vehicle
{
	void AddVehicle(T vehicle);
}
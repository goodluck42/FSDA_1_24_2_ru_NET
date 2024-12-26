namespace Covariance_Contravariance;

interface IGarage<out T>
	where T : Vehicle
{
	T GetVehicle(int id);
}
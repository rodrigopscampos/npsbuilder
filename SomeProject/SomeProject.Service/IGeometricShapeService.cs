using SomeProject.Domain.Models;

namespace SomeProject.Service
{
	public interface IGeometricShapeService
	{
		Circle CreateCircle(double radius);
		Square CreateSquare(double size);
	}
}

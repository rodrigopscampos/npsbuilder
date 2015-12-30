using SomeProject.Domain.Models;

namespace SomeProject.Service
{
	public class GeometricShapeService : IGeometricShapeService
	{
		public Circle CreateCircle(double radius)
		{
			return new Circle(radius);
		}

		public Square CreateSquare(double size)
		{
			return new Square(size);
		}
	}
}

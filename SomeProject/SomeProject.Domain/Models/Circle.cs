using System;

namespace SomeProject.Domain.Models
{
	public class Circle : GeometricShape
	{
		public readonly double Radius;

		public Circle(double radius)
		{
			this.Radius = radius;
		}

		public override double GetArea()
		{
			return Math.PI * Radius * Radius;
		}
	}
}

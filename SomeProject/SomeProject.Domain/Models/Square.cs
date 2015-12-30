namespace SomeProject.Domain.Models
{
	public class Square : GeometricShape
	{
		public readonly double Size;

		public Square(double size)
		{
			this.Size = size;
		}

		public override double GetArea()
		{
			return Size * Size;
		}
	}
}
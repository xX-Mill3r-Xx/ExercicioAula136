using ExercicioAula136.Entities.Enunms;
using ExercicioAula136.Entities;

namespace ExercicioAula136.Entities
{
    class Rectangle : Shapes
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

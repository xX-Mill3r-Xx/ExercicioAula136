using ExercicioAula136.Entities.Enunms;

namespace ExercicioAula136.Entities
{
    abstract class Shapes
    {
        public Color Color { get; set; }

        public Shapes(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}

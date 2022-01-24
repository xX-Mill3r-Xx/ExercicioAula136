using ExercicioAula136.Entities.Enunms;
using ExercicioAula136.Entities;
using System;

namespace ExercicioAula136.Entities
{
    class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; //Math.Pow(Radius, 2);//
        }
    }
}

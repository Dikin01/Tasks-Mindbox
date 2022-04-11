namespace Geometry.Shapes
{
    public class Circle : Shape
    {
        private double _radius;
        
        public double Radius
        {
            get => _radius;

            set
            {
                if (value > 0)
                    _radius = value;
                else
                    throw new ArgumentException("Радиус должен быть" +
                        "больше нуля");
            }
        }

        public Circle(double radius) =>
            Radius = radius;

        public override double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

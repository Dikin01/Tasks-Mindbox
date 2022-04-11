namespace Geometry.Shapes
{
    public class Triangle : Shape
    {
        private double _a, _b, _c;
        public double A
        {
            get => _a;
            set
            {
                if (IsSide(value))
                    _a = value;
                else
                    throw new ArgumentException("Сторона треугольника" +
                        "должна быть больше нуля");
            }
        }
        public double B
        {
            get => _b;
            set
            {
                if (IsSide(value))
                    _b = value;
                else
                    throw new ArgumentException("Сторона треугольника" +
                        "должна быть больше нуля");
            }
        }
        public double C
        {
            get => _c;
            set
            {
                if (IsSide(value))
                    _c = value;
                else
                    throw new ArgumentException("Сторона треугольника" +
                        "должна быть больше нуля");
            }
        }

        public Triangle(double a, double b, double c)
        {
            (A, B, C) = (a, b, c);
            if (!IsTriangle())
                throw new ArgumentException("Не треугольник");
        }


        public bool IsRightTriangle()
        {
            bool result = false;
            double Adeg2 = A * A;
            double Bdeg2 = B * B;
            double Cdeg2 = C * C;

            result |= (Adeg2 == Bdeg2 + Cdeg2);
            result |= (Bdeg2 == Adeg2 + Cdeg2);
            result |= (Cdeg2 == Adeg2 + Bdeg2);

            return result;
        }

        public override double FindArea()
        {            
            double p = (A + B + C) / 2;
            return Math.Sqrt(p*(p-A) * (p-B) * (p-C));
        }

        private bool IsSide(double value)
        {
            return value > 0;
        }

        private bool IsTriangle()
        {
            bool result = true;
            result &= A < B + C;
            result &= B < A + C;
            result &= C < B + A;
            return result;
        }
    }
}

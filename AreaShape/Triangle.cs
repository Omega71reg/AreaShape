namespace AreaShape
{
    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a,double b,double c)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
        }

        public double P() => (a + b + c) / 2;
        public override double Area()
        {
            if (a + b <= c || a + c <= b || c + b <= a) // Не знаем какая из переменных гипотенуза
                return -1; //Не треугольник
            if(Check())
                Console.WriteLine("Прямоугольный треугольник");
            double S = Math.Sqrt(P() * (P() - a) * (P() - b) * (P() - c));
            return S;
        }
        public bool Check() => ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a));
    }
}

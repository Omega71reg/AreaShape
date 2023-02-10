namespace AreaShape
{
    public class Shape
    {
        double S=0;
        virtual public double Area()
        {
            return S;
        }
        public Shape() { }
        public Shape(double r) => S = new Circle(r).Area();
        public Shape(double a, double b, double c) => S = new Triangle(a, b, c).Area();
        

    }
}
namespace PassByValue
{
    public class Calculate
    {
        public void Square(Point point)
        {
            point.X *= point.X;
        }

        public void SquareWithNewObject(Point point) => point = new Point
        {
            X = point.X * point.X
        };

        public void SquareWithNewObjectPassByRef(ref Point point) => point = new Point
        {
            X = point.X * point.X
        };
    }
}
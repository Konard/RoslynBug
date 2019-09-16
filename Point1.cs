namespace RoslynBug
{
    public class Point1
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point1(int x, int y) => (X, Y) = (x, y);
    }
}

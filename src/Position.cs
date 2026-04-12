public readonly struct Position
{
    public double X { get; } 
    public double Y { get; }
    public double Z { get; }

    public Position(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // public override string ToString()
    // {
    //     string str = $"({X}, {Y}, {Z})";
    //     return str;
    // }

    public override string ToString() => $"({X}, {Y}, {Z})"; // expression-bodied member
}
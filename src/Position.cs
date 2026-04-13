public readonly struct Position
{
    public double X { get; } 
    public double Y { get; }
    public double Z { get; }

    public Position(double x, double y, double z)
    {
        if (x < 0 || y < 0 || z < 0) throw new ArgumentException("Position coordinates cannot be negative.");  
        X = x;
        Y = y;
        Z = z;   
    }

    public override string ToString() => $"({X}, {Y}, {Z})"; // expression-bodied member
}

public class Robot
{
    public string Name { get; set; }
    public Position CurrentPosition { get; set; }

    public Robot(string name, Position currentPosition)
    {
        Name = name;
        CurrentPosition = currentPosition;
    }

    public void MoveTo(Position newPosition)
    {
        CurrentPosition = newPosition;
    }

    public override string ToString() => $"Robot {Name}'s position: {CurrentPosition}";
}
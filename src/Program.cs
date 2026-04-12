using System;

namespace RoboticsTraining;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"RoboticsTraning App v0.1 - {DateTime.Now:yyyy-MM-dd}");

        Robot cleanerRobot = new Robot("Cleaner", new Position(2.1, 3.2, 1.4));
        Console.WriteLine(cleanerRobot);
        cleanerRobot.MoveTo(new Position(2.5, 3.2, 1.4));
        Console.WriteLine(cleanerRobot);
    }
}

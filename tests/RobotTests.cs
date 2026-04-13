
using System.Reflection;

namespace RoboticsTraining.Tests;

public class RobotTests
{
    [Fact]
    public void RobotPositionTest()
    {
        // Arrange, Act
        Robot testRobot = new Robot("Test", new Position(1.0, 2.0, 3.0));
        
        // Assert
        Assert.Equal(1.0, testRobot.CurrentPosition.X);
        Assert.Equal(2.0, testRobot.CurrentPosition.Y);
        Assert.Equal(3.0, testRobot.CurrentPosition.Z);
    }

    [Fact]
    public void RobotMovingTest()
    {
        // Arrange
        Robot testRobot = new Robot("Test", new Position(1.0, 2.0, 3.0));
        
        // Act
        testRobot.MoveTo(new Position(4.0, 5.0, 6.0));

        // Assert
        Assert.Equal(4.0, testRobot.CurrentPosition.X);
        Assert.Equal(5.0, testRobot.CurrentPosition.Y);
        Assert.Equal(6.0, testRobot.CurrentPosition.Z);
    }

    [Fact]
    public void NegativeValueTest()
    {
        Assert.Throws<ArgumentException>(() => new Position(-1, 2, 3));
    }

}

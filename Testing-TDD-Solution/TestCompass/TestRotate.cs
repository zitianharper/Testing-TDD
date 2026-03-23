using System.Drawing;
using NUnit.Framework;
using Testing_TDD;

namespace TestCompass;
[TestFixture]
public class CompassTests
{
    private Compass compass;

    [SetUp]
    public void Setup()
    {
        // Initialise
        compass = new Compass(Point.North);
    }

    [Test]
    [TestCase]
    public void Rotate_ReturnsEast_WhenFacingNorthAndTurningRight()
    {
        // Arrange
        Point startingPoint = Point.North;
        Direction turnDirection = Direction.Right;

        // Act
        Point result = compass.Rotate(startingPoint, turnDirection);

        // Assert
        Assert.AreEqual(Point.East, result);
    }
}

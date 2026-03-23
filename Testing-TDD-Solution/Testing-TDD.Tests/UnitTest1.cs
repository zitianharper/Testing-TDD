

namespace Testing_TDD.Tests;

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

    [Test]

    public void Rotate_AllPoints_TurnRight_ReturnCorrectResults()
    {
        var compass = new Compass(Point.North);
        Assert.Multiple(() =>
        {
            Assert.That(compass.Rotate(Point.North, Direction.Right), Is.EqualTo(Point.East));
            Assert.That(compass.Rotate(Point.East, Direction.Right), Is.EqualTo(Point.South));
            Assert.That(compass.Rotate(Point.South, Direction.Right), Is.EqualTo(Point.West));
            Assert.That(compass.Rotate(Point.West, Direction.Right), Is.EqualTo(Point.North));

        });
    }
}

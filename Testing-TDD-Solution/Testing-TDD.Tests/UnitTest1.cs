

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
}

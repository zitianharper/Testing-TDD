using System.Drawing;
using NUnit.Framework;
namespace TestCompass
{
    [TestClass]
    public sealed class TestRotate
    {
        [Test]
        public void Rotate_FromNorth_TurnRight_ReturnsEast()
        {
        //Arrange - declare point and direction and rotate method
        var compass = new Compass();
        
        //Act - point and position after Rotate 
        var result = Compass.Rotate(Point.North, Direction.Right);


        //Assert - what should be returned after rotate
        Assert.AreEqual(Point.East, result);

    }
}
}

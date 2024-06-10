using NUnit.Framework;
using Unit_Test_Abhinav;
namespace Test_Case_Abhinav
{
    [TestFixture]
    public class TriangleTest1
    {
        // Test_Case_Abhinav
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expected = "The triangle is valid.";
            // Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual(expected, actual);
        }
    }
}
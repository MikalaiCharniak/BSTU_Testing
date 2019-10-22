using NUnit.Framework;
using Lab3;

namespace Tests
{
    [TestFixture]
    public class GeometryMethodsTest
    {
        [Test]
        public void CorrectTriangle()
        {
            Assert.IsTrue(GeometryMethods.IsTriangleExist(3, 4, 5));
        }

        [Test]
        public void UncorrectTriangle()
        {
            Assert.IsFalse(GeometryMethods.IsTriangleExist(100, 2, 4));
        }

        [Test]
        public void NegativeSideTriangle()
        {
            Assert.IsFalse(GeometryMethods.IsTriangleExist(-3, 4, 5));
        }

        [Test]
        public void NegativeSidesTriangle()
        {
            Assert.IsFalse(GeometryMethods.IsTriangleExist(-3, -4, -5));
        }

        //using attributes for testing many differents triangles
        [TestCase(2, 2, 4, ExpectedResult = false)]
        [TestCase(10, 8, 6, ExpectedResult = true)]
        [TestCase(90, 20, 30, ExpectedResult = true)]
        [TestCase(1, 2, 3, ExpectedResult = false)]
        [TestCase(100, 1, 1, ExpectedResult = false)]
        [TestCase(30, 40, 50, ExpectedResult = true)]
        public bool TrianglesTest(int firstSide, int secondeSide, int thridSide)
        {
            return GeometryMethods.IsTriangleExist(firstSide,secondeSide,thridSide);
        }
    }
}
using TriangleSolver;
using NUnit.Framework;
using System;


namespace TriangleTestSuhani

{
    [TestFixture]
    public class EquilateralTest
    {
        [Test]
        public void TestClass()
        {
            //arrange
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;
            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
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
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle =  60;
            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
using TriangleSolver;
using NUnit.Framework;
using System;


namespace TriangleTestSuhani

{
    [TestFixture]
    public class TriangleTestCases
    {

        // test-1 ---- EQUILATERAL test is perfromed ----
        [Test]
        public void Triangle_Test_of_EQUILATERAL()
        {
            int firstSide = 60;
            //arrange
            int secondSide = 60;
            int thirdSide = 60;
            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        // test-2.A ---- ISOSCELES test case 1 is perfromed ----
        public void ValideTringle_InputTest_1_ForIsosceles()
        {
            //Arragne
            int firstSide = 40;
            int secondSide = 40;
            int thirdSide = 100;


            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        // test-2.B ---- ISOSCELES test case 2 is perfromed ----
        public void ValideTringle_InputTest_2_ForIsosceles()
        {
            //Arragne
            int firstSide = 75;
            int secondSide = 30;
            int thirdSide = 75;


            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        // test-2.C ---- ISOSCELES test case 3 is perfromed ----
        public void ValideTringle_InputTest_3_ForIsosceles()
        {
            //Arragne
            int firstSide = 40;
            int secondSide = 70;
            int thirdSide = 70;


            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }

}
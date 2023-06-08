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

        // test-3.A ---- SCALENE test case 1 is perfromed ----
        public void ValideTringle_InputTest1_ForScalane()
        {
            //Arragne
            int firstSide = 70;
            int secondSide = 60;
            int thirdSide = 50;


            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        // test-3.B ---- SCALENE test case 2 is perfromed ----
        public void ValideTringle_InputTest2_ForScalane()
        {
            //Arragne
            int firstSide = 60;
            int secondSide = 65;
            int thirdSide = 55;


            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        // test-3.C ---- SCALENE test case 3 is perfromed ----
        public void ValideTringle_InputTest3_ForScalane()
        {
            //Arragne
            int firstSide = 75;
            int secondSide = 45;
            int thirdSide = 60;


            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        // test-3.D ---- SCALENE test case 4 is perfromed ----
        public void ValideTringle_InputTest4_ForScalane()
        {
            //Arragne
            int firstSide = 80;
            int secondSide = 40;
            int thirdSide = 60;


            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        // test-3.E ---- SCALENE test case 5 is perfromed ----
        public void ValideTringle_InputTest5_ForScalane()
        {
            //Arragne
            int firstSide = 40;
            int secondSide = 55;
            int thirdSide = 85;


            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
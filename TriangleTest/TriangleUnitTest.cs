using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TriangleTest
{
    [TestFixture]
    internal class TriangleUnitTest
    {

        [Test]
        public void ValidEquilateralTriangle_Input60and60and60_OutputEquilateralTriangle()
        {
            // Arrange
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "Equilateral triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }


        [Test]
        public void ValidIsoscelesTriangle_Input3000and30and20_OutputIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 30;
            int secondSide = 30;
            int thirdSide = 20;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input30and20and30_OutputIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 30;
            int secondSide = 20;
            int thirdSide = 30;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input20and30and30_OutputIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 20;
            int secondSide = 30;
            int thirdSide = 30;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input30and40and50_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 30;
            int secondSide = 40;
            int thirdSide = 50;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input50and40and30_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 50;
            int secondSide = 40;
            int thirdSide = 30;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input40and50and30_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 40;
            int secondSide = 50;
            int thirdSide = 30;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input50and30and40_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 50;
            int secondSide = 30;
            int thirdSide = 40;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input40and30and50_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 40;
            int secondSide = 30;
            int thirdSide = 50;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }


    }
}


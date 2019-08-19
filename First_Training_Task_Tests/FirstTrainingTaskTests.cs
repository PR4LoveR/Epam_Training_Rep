using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using First_Training_Task;
using Circle_Name;
using Rectangle_Name;

namespace First_Training_Task_Tests
{
    [TestFixture]
    public class FirtsTrainingTestsClass
    {
        [Test]
        public void CircleMathodTesting()
        {
            // arrange
            int radius_1 = 1;
            int radius_2 = 2;
            int radius_3 = 3;
            int radius_4 = 4;

            double actualSquare1 = 3.14;
            double actualSquare2 = 12.566;
            double actualSquare3 = 28.274;
            double actualSquare4 = 50.265;

            double actualLangth1 = 6.283;
            double actualLangth2 = 12.566;
            double actualLangth3 = 18.849;
            double actualLangth4 = 25.132;

            // action
            double resultLength1 = Circle.Langth(radius_1);
            double resultLangth2 = Circle.Langth(radius_2);
            double resultLangth3 = Circle.Langth(radius_3);
            double resultLangth4 = Circle.Langth(radius_4);

            double resultSquare1 = Circle.Square(radius_1);
            double resultSquare2 = Circle.Square(radius_2);
            double resultSquare3 = Circle.Square(radius_3);
            double resultSquare4 = Circle.Square(radius_4);

            //asert
            Assert.AreEqual(resultSquare1, actualSquare1);
            Assert.AreEqual(resultSquare2, actualSquare2);
            Assert.AreEqual(resultSquare3, actualSquare3);
            Assert.AreEqual(resultSquare4, actualSquare4);

            Assert.AreEqual(resultLength1, actualLangth1);
            Assert.AreEqual(resultLangth2, actualLangth2);
            Assert.AreEqual(resultLangth3, actualLangth3);
            Assert.AreEqual(resultLangth4, actualLangth4);
        }

        public void RactangleMathodTests()
        {
            //arrange
            Rectangle.sideA = 3;
            Rectangle.sideB = 4;

            int actualPerimetr = 14;
            int actualSquare = 12;

            //action
            Rectangle rectangle = new Rectangle(null, null);
            int resultPerimeter = rectangle.Perimeter();
            int resultSquare = rectangle.Square();

            //assert
            Assert.AreEqual(actualPerimetr, resultPerimeter);
            Assert.AreEqual(actualSquare, resultSquare);

        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMagazinePosition.Tests
{
    [TestClass]
    public class TestMagazinePosition
    {
        private bool[] _places;
        public TestMagazinePosition()
        {
            _places = new bool[12];
            _places[0] = false;
            _places[1] = false;
            _places[2] = false;
            _places[3] = true;
            _places[4] = true;
            _places[5] = false;
            _places[6] = false;
            _places[7] = false;
            _places[8] = false;
            _places[9] = true;
            _places[10] = false;
            _places[11] = false;

        }
        [TestMethod]
        public void ShouldReturnMinusNumberIfPositionsDoesNotFound()
        {
            //Arrange
            bool isRotate = false;
            int neededPlaces = 6;

            //Act
            var expectedResult = -1;
            var acturalResult = FindPostionForm.FindFreePlace(_places, isRotate, neededPlaces);

            //Assert
            Assert.AreEqual(expectedResult, acturalResult);
        }

        [TestMethod]
        public void ShouldReturnMinusNumberIfNeededPlacesGreaterThanMagazine()
        {
            //Arrange

            bool isRotate = false;
            int neededPlaces = 15;

            //Act
            var expectedResult = -1;
            var acturalResult = FindPostionForm.FindFreePlace(_places, isRotate, neededPlaces);

            //Assert
             Assert.AreEqual(expectedResult, acturalResult);
        }

        [TestMethod]
        public void ShouldReturnPositiveNumberIfPositionsDoFound()
        {
            //Arrange
            bool isRotate = false;
            int neededPlaces = 4;

            //Act
            var expectedResult = 5; 
            var acturalResult = FindPostionForm.FindFreePlace(_places, isRotate, neededPlaces);

            //Assert
            Assert.AreEqual(expectedResult, acturalResult);
        }

        [TestMethod]
        public void ShouldReturnPositiveNumberIfisRotateAndPositionsFound()
        {
            //Arrange
             bool isRotate = true;
            int neededPlaces = 5;

            //Act
            var expectedResult = 10;
            var acturalResult = FindPostionForm.FindFreePlace(_places, isRotate, neededPlaces);

            //Assert
            Assert.AreEqual(expectedResult, acturalResult);
        }

    }
}

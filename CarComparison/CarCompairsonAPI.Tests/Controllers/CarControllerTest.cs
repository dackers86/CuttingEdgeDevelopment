using System;
using CarCompairsonAPI.Controllers;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CarCompairsonAPI.Models;
using CarCompairsonAPI.Repository;
using Rhino.Mocks;

namespace CarCompairsonAPI.Tests.Controllers
{
    [TestFixture]
    public class CarControllerTest
    {
        private ICarRepository _mockCarRepository;
        private CarController _carController;

        [SetUp]
        public void SetupTests()
        {
            _mockCarRepository = MockRepository.GenerateMock<ICarRepository>();
            _carController = new CarController();
        }

        [Test]
        public void Get()
        {
            // Arrange
            _mockCarRepository.Expect(x => x.GetAllCars())
                              .Repeat.Once()
                              .Return(new List<Car>());
            
            // Act
            var result = _carController.Post(new Car { });

            // Assert
            Assert.IsNotNull(result);
        }


        [Test]
        public void GetById()
        {
            // Arrange
            _mockCarRepository = MockRepository.GenerateMock<ICarRepository>();

            int carId = 1;
            _mockCarRepository.Expect(x => x.GetCarById(carId))
                              .Repeat.Once()
                              .Return(new Car { Id = 1 });

            // Act
            var result = _carController.Get(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);
        }

        [Test]
        public void Create()
        {

        }

    }
}

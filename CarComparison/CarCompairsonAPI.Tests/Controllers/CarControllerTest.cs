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
        private ICarController _mockCarController;
        private CarController carController;

        [SetUp]
        public void SetupTests()
        {
            _mockCarRepository = MockRepository.GenerateMock<ICarRepository>();
            carController = new CarController();
        }

        [Test]
        public void Get()
        {
            //Arrange
            var carList = new List<Car>() 
            { new Car
                { 
                    Name = "Test", 
                    Model = new Model
                    { 
                        Name = "TestModel" 
                    } 
                } 
            };

            _mockCarRepository.Stub(x => x.GetAllCars())
                  .Repeat.Once()
                  .Return(carList);

            carController.carRepository = _mockCarRepository;

            // Act
            var result = carController.Get();

            //Assert
            Assert.IsNotNull(result);
            _mockCarRepository.VerifyAllExpectations();
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

            carController.carRepository = _mockCarRepository;

            // Act
            var result = carController.Get(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);
        }

        [Test]
        public void Create()
        {
            // Arrange
            var car = new Car { };

            _mockCarRepository.Expect(x => x.AddCar(car))
                              .Repeat.Once()
                              .Return(car);

            carController.carRepository = _mockCarRepository;

            // Act
            var result = carController.Post(car);

            // Assert
            Assert.IsNotNull(result);
            _mockCarRepository.VerifyAllExpectations();
        }

    }
}

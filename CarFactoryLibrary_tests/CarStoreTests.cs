using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCar_AddBMW_ListDoesNotContainObject()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };
            BMW bmw = new BMW();

            // Act
            carStore.AddCar(bmw);

            // Collection Asserts
            Assert.NotEmpty(carStore.cars);
            Assert.DoesNotContain<Car>(bmw, carStore.cars);
            Assert.DoesNotContain<Car>(carStore.cars, c => c.velocity == 10);
        }

        [Fact]
        public void AddCar_AddToyota_ListContainsObject()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };

            // Act
            carStore.AddCar(toyota);

            // Collection Asserts
            Assert.Contains<Car>(toyota, carStore.cars);
        }


    }
}

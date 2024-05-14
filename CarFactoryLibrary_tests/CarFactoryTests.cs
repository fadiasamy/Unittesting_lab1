using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class CarFactoryTests
    {
        [Fact]
        public void NewCar_AskForBMW_BMWObject()
        {
            // Act
            Car? result = CarFactory.NewCar(CarTypes.BMW);

            // Type Assert
            Assert.IsType<BMW>(result);
            Assert.IsNotType<Toyota>(result);

            Assert.IsAssignableFrom<Car>(result);
        }

        [Fact]
        public void NewCar_ReturnsToyotaInstance()
        {
            // Arrange
            CarTypes carType = CarTypes.Toyota;

            // Act
            Car result = CarFactory.NewCar(carType);

            // Type Assert
            Assert.IsType<Toyota>(result);
        }


        [Fact]
        public void NewCar_AskForHonda_Exception()
        {
            // Exception Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
            Assert.ThrowsAny<Exception>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });

        }










    }
}

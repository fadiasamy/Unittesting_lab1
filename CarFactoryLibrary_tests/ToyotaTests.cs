using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    
    public class ToyotaTests
    {
       
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void IsStopped_Velocity10_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = -5;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.False(actualResult);
        }


        [Fact]
        public void IncreaseVelocity_Velocity1000AddNegative200_Velocity800()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 1000 };
            double addedVelocity = -200;

            // Act
            toyota.IncreaseVelocity(addedVelocity);

            // Numeric Assert
            Assert.Equal(800, toyota.velocity);
        }

        [Fact]
        public void IncreaseVelocity_Velocity500AddPositive300_Velocity800()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 500 };
            double addedVelocity = 300;

            // Act
            toyota.IncreaseVelocity(addedVelocity);

            // Numeric Assert
            Assert.Equal(800, toyota.velocity);
        }


        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Stopped };

            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Stopped", result);

            Assert.StartsWith("S", result);

            Assert.EndsWith("ped", result);

            Assert.Contains("top", result);

            Assert.DoesNotContain("xyz", result);

            Assert.Matches("[A-Z][a-z]{6}", result);

            Assert.DoesNotMatch("[A-Z][a-z]{8}", result);
        }
        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };

            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Forward", result);
        }

        

        [Fact]
        public void GetDirection_DirectionInvalid_Unknown()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = (DrivingMode)100 }; 

            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Unknown", result);
        }
       
        [Fact]
        public void GetDirection_DirectionIdle_Idle()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Backward };

            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Backward", result);
        }







        [Fact]
        public void GetMyCar_DifferentInstances_ReturnDifferentReferences()
        {
            // Arrange
            Toyota toyota1 = new Toyota();
            Toyota toyota2 = new Toyota();

            // Act
            Car car1 = toyota1.GetMyCar();
            Car car2 = toyota2.GetMyCar();

            // Reference Assert
            Assert.NotSame(car1, car2);
            Assert.Same(toyota1, car1);
            Assert.Same(toyota2, car2);
        }

        [Fact]
        public void GetMyCar_SameInstance_ReturnSameReference()
        {
            // Arrange
            Toyota toyota = new Toyota();

            // Act
            Car car1 = toyota.GetMyCar();
            Car car2 = toyota.GetMyCar();

            // Reference Assert
            Assert.Same(car1, car2);
        }

    }
}

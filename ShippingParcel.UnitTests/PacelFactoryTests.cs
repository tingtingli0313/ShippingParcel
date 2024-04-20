using ShippingParcel.Core;
using ShippingParcel.Core.Models;

namespace ShippingParcel.UnitTests
{
    public class PacelFactoryTests
    {
        [Theory]
        [InlineData(5, 5, 5, typeof(SmallParcel), 3)]
        [InlineData(10, 10, 10, typeof(MediumParcel), 8)]
        [InlineData(49, 49, 49, typeof(MediumParcel), 8)]
        [InlineData(50, 50, 50, typeof(LargeParcel), 15)]
        [InlineData(99, 99, 99, typeof(LargeParcel), 15)]
        [InlineData(100, 100, 100, typeof(ExLargeParcel), 25)]
        public void ParcelGenerator_ReturnsCorrectParcelType(int height, int length, int width, Type expectedParcelType, int expectedCost)
        {
            // Arrange

            // Act
            var parcel = ShippingParcelFactory.ParcelGenerator(height, length, width);

            // Assert
            Assert.IsType(expectedParcelType, parcel);
            Assert.Equal(expectedCost, parcel.GetTotalCost());
        }

        [Fact]
        public void ParcelGenerator_ThrowsExceptionForInvalidDimensions()
        {
            // Arrange
            int height = 0, length = 0, width = 0;

            // Act & Assert
            Assert.Throws<Exception>(() => ShippingParcelFactory.ParcelGenerator(height, length, width));
        }

      
    }
}
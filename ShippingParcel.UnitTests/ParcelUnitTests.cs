using ShippingParcel.Core.Models;
using ShippingParcel.Core;

namespace ShippingParcel.UnitTests;

public class ParcelUnitTests
{

    [Fact]
    public void LargeParcel_WithSpeedyShipping_TotalShouldDouble_SpeedyCostShouldSet()
    {
        // Arrange
        var largeParcel = new LargeParcel();

        // Act
        largeParcel.SetSpeedyShipping();

        // Assert
        Assert.Equal(largeParcel._originalCost * 2, largeParcel.GetsSpeedyShippingCost());
    }

    [Fact]
    public void MediumParcel_WithSpeedyShipping_TotalShouldDouble_SpeedyCostShouldSet()
    {
        // Arrange
        var parcel = new MediumParcel();

        // Act
        parcel.SetSpeedyShipping();

        // Assert
        Assert.Equal(parcel._originalCost * 2, parcel.GetsSpeedyShippingCost());
    }


    [Fact]
    public void SmallParcel_WithSpeedyShipping_TotalShouldDouble_SpeedyCostShouldSet()
    {
        // Arrange
        var parcel = new SmallParcel();

        // Act
        parcel.SetSpeedyShipping();

        // Assert
        Assert.Equal(parcel._originalCost * 2, parcel.GetsSpeedyShippingCost());
    }

    [Fact]
    public void ExtraLargeParcel_WithSpeedyShipping_TotalShouldDouble_SpeedyCostShouldSet()
    {
        // Arrange
        var parcel = new ExLargeParcel();

        // Act
        parcel.SetSpeedyShipping();

        // Assert
        Assert.Equal(parcel._originalCost * 2, parcel.GetsSpeedyShippingCost());
    }
}

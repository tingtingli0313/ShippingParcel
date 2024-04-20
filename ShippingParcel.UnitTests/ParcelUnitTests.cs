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
        Assert.Equal(largeParcel.OriginalCost * 2, largeParcel.GetsSpeedyShippingCost());
        Assert.Equal(largeParcel.GetTotalCost(), (largeParcel.OriginalCost * 2));
    }

    [Fact]
    public void MediumParcel_WithSpeedyShipping_TotalShouldDouble_SpeedyCostShouldSet()
    {
        // Arrange
        var parcel = new MediumParcel();

        // Act
        parcel.SetSpeedyShipping();

        // Assert
        Assert.Equal(parcel.OriginalCost * 2, parcel.GetsSpeedyShippingCost());
        Assert.Equal(parcel.GetTotalCost(), (parcel.OriginalCost * 2));
    }


    [Fact]
    public void SmallParcel_WithSpeedyShipping_TotalShouldDouble_SpeedyCostShouldSet()
    {
        // Arrange
        var parcel = new SmallParcel();

        // Act
        parcel.SetSpeedyShipping();

        // Assert
        Assert.Equal(parcel.OriginalCost * 2, parcel.GetsSpeedyShippingCost());
        Assert.Equal(parcel.GetTotalCost(), (parcel.OriginalCost * 2));
    }

    [Fact]
    public void ExtraLargeParcel_WithSpeedyShipping_andOverweigh_TotalShouldDouble_SpeedyCostShouldSet()
    {
        // Arrange
        var parcel = new ExLargeParcel();

        // Act
        parcel.SetSpeedyShipping();
        parcel.SetWeightInKg(11);

        // Assert
        Assert.NotEqual(parcel.GetTotalCost(), (parcel.OriginalCost + parcel.OverweighCost )* 2);
    }


    [Fact]
    public void LargeParcel_WithOverweightShipping_TotalShouldChange_OverweightCostShouldSet()
    {
        // Arrange
        var largeParcel = new LargeParcel();

        // Act
        largeParcel.SetWeightInKg(10); //(10-6)*2

        // Assert
        Assert.Equal(8, largeParcel.OverweighCost);
        Assert.Equal(largeParcel.GetTotalCost(), largeParcel.OverweighCost + largeParcel.OriginalCost);
    }

    [Fact]
    public void MediumParcel_WithWeightInRanage_TotalShouldNotChange_OverweightCostShouldBeZero()
    {
        // Arrange
        var parcel = new MediumParcel();

        // Act
        parcel.SetWeightInKg(3);

        // Assert
        Assert.Equal(0, parcel.OverweighCost);
        Assert.Equal(parcel.GetTotalCost(), parcel.OriginalCost);
    }

    [Fact]
    public void MediumParcel_WithOverWeight_TotalShouldChange_OverweightCostShouldBeSet()
    {
        // Arrange
        var parcel = new MediumParcel();

        // Act
        parcel.SetWeightInKg(4);

        // Assert
        Assert.Equal(2, parcel.OverweighCost);
        Assert.Equal(parcel.GetTotalCost(), parcel.OriginalCost+2);
    }

    [Fact]
    public void SmallParcel_SetWeightShipping_TotalShouldChange_OverweightCostShouldSet()
    {
        // Arrange
        var parcel = new SmallParcel();

        // Act
        parcel.SetWeightInKg(3);

        // Assert
        Assert.Equal(4, parcel.OverweighCost);
        Assert.Equal(parcel.GetTotalCost(), parcel.OriginalCost + 4);
    }

    [Fact]
    public void ExtraLargeParcel_WithOverweightShipping_TotalShouldChange_OverweightCostShouldSet()
    {
        // Arrange
        var parcel = new ExLargeParcel();

        // Act
        parcel.SetWeightInKg(15);

        // Assert
        Assert.Equal(10, parcel.OverweighCost);
        Assert.Equal(parcel.GetTotalCost(), parcel.OriginalCost + 10);
    }
}

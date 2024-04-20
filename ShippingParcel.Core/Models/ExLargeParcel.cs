namespace ShippingParcel.Core.Models;

public class ExLargeParcel : IParcel
{
    public int GetLimitDimensionInCm()
    {
        return 100;
    }

    public string GetParcelType()
    {
        return "ExtraLarge";
    }

    public int GetTotalCost()
    {
        return 25;
    }
}
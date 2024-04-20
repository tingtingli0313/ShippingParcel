namespace ShippingParcel.Core.Models;

public class LargeParcel : IParcel
{
    public int GetLimitDimensionInCm()
    {
        return 100;
    }

    public int GetOverweightCost()
    {
        throw new NotImplementedException();
    }

    public string GetParcelType()
    {
        return "Large";
    }

    public int GetTotalCost()
    {
        return 15;
    }
}

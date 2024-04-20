namespace ShippingParcel.Core.Models;

public class SmallParcel : IParcel
{
    public int GetOverweightCost()
    {
        throw new NotImplementedException();
    }

    public string GetParcelType()
    {
        return "Small";
    }

    public int GetTotalCost()
    {
        return 3;
    }

    public int GetLimitDimensionInCm()
    {
        return 10;
    }
}



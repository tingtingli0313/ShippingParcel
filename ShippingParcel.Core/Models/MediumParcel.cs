namespace ShippingParcel.Core.Models;

public class MediumParcel : IParcel
{
    public int GetLimitDimensionInCm()
    {
        return 50;
    }

    public int GetOverweightCost()
    {
        throw new NotImplementedException();
    }

    public string GetParcelType()
    {
        return "Medium";
    }

    public int GetTotalCost()
    {
        return 8;
    }
}

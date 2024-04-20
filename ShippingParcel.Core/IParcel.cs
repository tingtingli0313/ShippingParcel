namespace ShippingParcel.Core
{
    public interface IParcel
    {
        string GetParcelType();
        int GetTotalCost();
        int GetLimitDimensionInCm();
    }
}
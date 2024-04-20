namespace ShippingParcel.Core
{
    public interface IParcel
    {
        string GetParcelType();
        int GetTotalCost();
        int GetLimitDimensionInCm();
        void SetSpeedyShipping();
        int GetsSpeedyShippingCost();
        void SetWeightInKg(int weight);
    }
}
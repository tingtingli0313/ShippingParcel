namespace ShippingParcel.Core.Models;

public class MediumParcel : IParcel
{
    private bool _isSpeedyShipping { get; set; }
    private int _speedyShippingCost { get; set; }

    public readonly int OriginalCost = 8;
    private int _weight { get; set; }
    public int OverweighCost { get; private set; }
    public int OverweightInKgLimit { get; private set; } = 3;

    public MediumParcel()
    {
        
    }
    public int GetLimitDimensionInCm()
    {
        return 50;
    }

    public string GetParcelType()
    {
        return "Medium";
    }

    public int GetTotalCost()
    {
        int total = OriginalCost;

        total += OverweighCost;

        if (_isSpeedyShipping)
        {
            total = total * 2;
        }

        return total;
    }

    public void SetSpeedyShipping()
    {
        _isSpeedyShipping = true;
    }

    public int GetsSpeedyShippingCost()
    {
        return GetTotalCost();
    }

    public void SetWeightInKg(int weight)
    {
        _weight = weight;

        if (_weight > OverweightInKgLimit)
        {
            OverweighCost = (_weight - OverweightInKgLimit) * 2;
        }
    }
}

namespace ShippingParcel.Core.Models;

public class SmallParcel : IParcel
{
    private bool _isSpeedyShipping { get; set; } = false;
    private int _speedyShippingCost { get; set; }
    public int OverweighCost { get; private set; }
    private int _weight { get; set; }

    public readonly int OriginalCost = 3;

    public readonly int OverweightInKgLimit = 1;

    public string GetParcelType()
    {
        return "Small";
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
        _speedyShippingCost = OriginalCost * 2;
    }

    public int GetsSpeedyShippingCost()
    {
        return _speedyShippingCost;
    }

    public int GetLimitDimensionInCm()
    {
        return 10;
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



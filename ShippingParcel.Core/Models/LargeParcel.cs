namespace ShippingParcel.Core.Models;

public class LargeParcel : IParcel
{
    private bool _isSpeedyShipping { get; set; }
    private int _speedyShippingCost { get; set; } = 0;
    private int _weight { get; set; }
    public int OverweighCost { get; private set; }

    public readonly int OverweightInKgLimit = 6;

    public readonly int OriginalCost = 15;
    
    public LargeParcel()
    {

    }
    public int GetLimitDimensionInCm()
    {
        return 100;
    }

    public string GetParcelType()
    {
        return "Large";
    }

    public int GetTotalCost()
    {
        int total = OriginalCost;
       
        total += OverweighCost;

        if (_isSpeedyShipping)
        {
           total *= 2;
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

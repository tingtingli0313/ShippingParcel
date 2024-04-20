namespace ShippingParcel.Core.Models;

public class ExLargeParcel : IParcel
{
    private bool _isSpeedyShipping { get; set; }
    private int _speedyShippingCost { get; set; }
    private int _weight { get; set; }
    public int OverweighCost { get; private set; }

    public readonly int OriginalCost = 25;
    public readonly int OverweightInKgLimit = 10;

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
        int total = OriginalCost;
        if (_isSpeedyShipping)
        {
            _speedyShippingCost = OriginalCost * 2;
            total += _speedyShippingCost;
        }
        total += OverweighCost;
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

    public void SetWeightInKg(int weight)
    {
        _weight = weight;
        if (_weight > OverweightInKgLimit)
        {
           OverweighCost = (_weight - OverweightInKgLimit) * 2;
        }
    }
}
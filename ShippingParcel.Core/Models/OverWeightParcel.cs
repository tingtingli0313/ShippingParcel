

namespace ShippingParcel.Core.Models;
public class OverWeightParcel : IParcel
{
    private bool _isSpeedyShipping { get; set; } = false;
    private int _speedyShippingCost { get; set; }
    public int OverweighCost { get; private set; }
    private int _weight { get; set; }

    public readonly int OriginalCost = 50;

    public readonly int OverweightInKgLimit = 50;

    public string GetParcelType()
    {
        return "Overweight";
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
        return _speedyShippingCost;
    }

    public int GetLimitDimensionInCm()
    {
        throw new NotImplementedException();
    }

    public void SetWeightInKg(int weight)
    {
        _weight = weight;

        if (_weight >= OverweightInKgLimit)
        {
            OverweighCost = (_weight - OverweightInKgLimit);
        }
    }
}

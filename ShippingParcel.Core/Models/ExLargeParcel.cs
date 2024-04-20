namespace ShippingParcel.Core.Models;

public class ExLargeParcel : IParcel
{
    private bool _isSpeedyShipping { get; set; }
    private int _speedyShippingCost { get; set; }

    public readonly int _originalCost = 25;

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
        int total = _originalCost;
        if (_isSpeedyShipping)
        {
            _speedyShippingCost = _originalCost * 2;
            total += _speedyShippingCost;
        }
        return total;
    }

    public void SetSpeedyShipping()
    {
        _isSpeedyShipping = true;
        _speedyShippingCost = _originalCost * 2;
    }

    public int GetsSpeedyShippingCost()
    {
        return _speedyShippingCost;
    }
}
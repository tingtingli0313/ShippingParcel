namespace ShippingParcel.Core.Models;

public class SmallParcel : IParcel
{

    private bool _isSpeedyShipping { get; set; } = false;
    private int _speedyShippingCost { get; set; }

    public readonly int _originalCost = 3;


    public string GetParcelType()
    {
        return "Small";
    }

    public int GetTotalCost()
    {
        int total = _originalCost;
        if (_isSpeedyShipping)
        {
            _speedyShippingCost = total * 2;
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
    public int GetLimitDimensionInCm()
    {
        return 10;
    }
}



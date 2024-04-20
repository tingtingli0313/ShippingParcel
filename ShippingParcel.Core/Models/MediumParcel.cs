namespace ShippingParcel.Core.Models;

public class MediumParcel : IParcel
{
    private bool _isSpeedyShipping { get; set; }
    private int _speedyShippingCost { get; set; }

    public readonly int _originalCost = 8;

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

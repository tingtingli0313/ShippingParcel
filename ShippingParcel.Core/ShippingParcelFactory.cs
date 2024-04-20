
using ShippingParcel.Core.Models;

namespace ShippingParcel.Core;

public class ShippingParcelFactory
{
    public static IParcel ParcelGenerator(int height, int length, int width)
    {
        IParcel parcelDetails = null;
        var parcelType = GetParcelType(height, length, width);

        switch (parcelType)
        {
            case ParcelType.Small:
                parcelDetails = new SmallParcel();
                break;
            case ParcelType.Medium:
                parcelDetails = new MediumParcel();
                break;
            case ParcelType.Large:
                parcelDetails = new LargeParcel();
                break;
            case ParcelType.ExtraLarge:
                parcelDetails = new ExLargeParcel();
                break;
            default:
                throw new Exception();
        }

        return parcelDetails;
    }

    private static ParcelType GetParcelType(int height, int length, int width)
    {
        int decider = width;
        if (length > decider)
            decider = length;
        if (height > decider)
            decider = height;

        if (decider > 0 && decider < 10)
            return ParcelType.Small;
        else if (decider >= 10 && decider < 50)
            return ParcelType.Medium;
        else if (decider >= 50 && decider < 100)
            return ParcelType.Large;
        else if (decider >= 100)
            return ParcelType.ExtraLarge;
        else
            return ParcelType.None;
    }
}

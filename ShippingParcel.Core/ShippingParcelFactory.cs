
using ShippingParcel.Core.Models;

namespace ShippingParcel.Core;

public class ShippingParcelFactory
{
    public static IParcel ParcelGenerator(int height, int length, int width, int weight)
    {
        IParcel parcelDetails = null;
        var parcelType = GetParcelType(height, length, width, weight);
     
        switch (parcelType)
        {
            case ParcelType.Small:
                parcelDetails = new SmallParcel();
                parcelDetails.SetWeightInKg(weight);
                break;
            case ParcelType.Medium:
                parcelDetails = new MediumParcel();
                parcelDetails.SetWeightInKg(weight);
                break;
            case ParcelType.Large:
                parcelDetails = new LargeParcel();
                parcelDetails.SetWeightInKg(weight);
                break;
            case ParcelType.ExtraLarge:
                parcelDetails = new ExLargeParcel();
                parcelDetails.SetWeightInKg(weight);
                break;
            case ParcelType.OverWeight:
                parcelDetails = new OverWeightParcel();
                parcelDetails.SetWeightInKg(weight);
                break;
            default:
                throw new Exception();
        }

        return parcelDetails;
    }

    private static ParcelType GetParcelType(int height, int length, int width, int weight)
    {
        int decider = width;
        if (length > decider)
            decider = length;
        if (height > decider)
            decider = height;

        if (decider > 0 && decider < 10 && weight < 50)
            return ParcelType.Small;
        else if (decider >= 10 && decider < 50 && weight < 50)
            return ParcelType.Medium;
        else if (decider >= 50 && decider < 100 && weight < 50)
            return ParcelType.Large;
        else if (decider >= 100 && weight < 50)
            return ParcelType.ExtraLarge;
        else if (weight >= 50)
            return ParcelType.OverWeight;
        else
            return ParcelType.None;
    }
}

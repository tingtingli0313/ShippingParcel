using ShippingParcel.Core.Models;
using System.Security.AccessControl;

namespace ShippingParcel.Core;

public class ShippingParcelService
{
    private ShippingParcelFactory _shippingParcelFactory { get; set; }
    public List<IParcel> Parcels = new List<IParcel>() { };
    public ShippingParcelService(ShippingParcelFactory shippingParcelFactory)
    {
        _shippingParcelFactory = shippingParcelFactory;
    }

    public void AddParcel(int height, int length, int width, int weight)
    {
        var parcel = ShippingParcelFactory.ParcelGenerator(height, length, width, weight);
        Parcels.Add(parcel);
    }

    public int GetDiscount()
    {
        var discount = 0;
        List<SmallParcel> smallParcels = Parcels.OfType<SmallParcel>().ToList();
        if (smallParcels.Count >= 4)
        {
            // set the minimus one as discount value
            discount = -(smallParcels.Select(x => x.GetTotalCost()).ToList().Min());
            return discount;
        }

        List<MediumParcel> mediumParcels = Parcels.OfType<MediumParcel>().ToList();
        if (mediumParcels.Count >= 3)
        {
            // set the minimus one as discount value
            discount = -(mediumParcels.Select(x => x.GetTotalCost()).ToList().Min());
            return discount;
        }

        if (Parcels.Count >= 5)
        {
            // set the minimus one as discount value
            discount = -(smallParcels.Select(x => x.GetTotalCost()).ToList().Min());
            return discount;
        }


        return discount;
    }
}

using ShippingParcel.Core;
using ShippingParcel.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingParcel.UnitTests
{
    public class ShippingparcelServiceUnittests
    {
        public ShippingparcelServiceUnittests()
        {

        }

        [Fact]
        public void ShippingService_With4SmallParcle_GetDiscountValueBack()
        {

            var Service = new ShippingParcelService(new ShippingParcelFactory());

           // Act
            Service.AddParcel(6, 6, 6, 1);
            Service.AddParcel(6, 6, 6, 1);
            Service.AddParcel(6, 6, 6, 1);
            Service.AddParcel(6, 6, 6, 1);

            // Assert
            Assert.Equal(-3, Service.GetDiscount());
        }

        [Fact]
        public void ShippingService_With3SmallParcle_ReturnNoDiscount()
        {
            //Arrange
            var Service = new ShippingParcelService(new ShippingParcelFactory());

            // Act
            Service.AddParcel(6, 6, 6, 1);
            Service.AddParcel(6, 6, 6, 1);
            Service.AddParcel(6, 6, 6, 1);

            // Assert
            Assert.Equal(0, Service.GetDiscount());
        }


        [Fact]
        public void ShippingService_WithMixParcle_GetDiscountValueBack()
        {
            //Arrange
            var Service = new ShippingParcelService(new ShippingParcelFactory());
            // Act
            Service.AddParcel(50, 50, 30, 1);
            Service.AddParcel(10, 30, 30, 1);
            Service.AddParcel(50, 30, 30, 1);
            Service.AddParcel(8, 8, 7, 1);
            Service.AddParcel(30, 30, 30, 1);
            // Assert
            Assert.Equal(-3, Service.GetDiscount());
        }

        [Fact]
        public void ShippingService_WithMediumParcle_GetDiscountValueBack()
        {
            //Arrange
            var Service = new ShippingParcelService(new ShippingParcelFactory());
            // Act
            Service.AddParcel(10, 30, 30, 1);
            Service.AddParcel(30, 30, 30, 1);
            Service.AddParcel(30, 30, 30, 1);

            // Assert
            Assert.Equal(-8, Service.GetDiscount());
        }
    }
}

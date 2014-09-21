
namespace template_pattern.Shipment
{
    public class UPSShipment : OrderShipment
    {
        protected override void GetShippingLabelFromCarrier()
        {
            Label = string.Format("UPS: [{0}]\n\n", ShippingAddress);
        }
    }
}

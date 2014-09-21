namespace template_pattern.Shipment
{
    public class FedExShipment : OrderShipment
    {
        protected override void GetShippingLabelFromCarrier()
        {
            Label = string.Format("FedEx: [{0}]\n\n", ShippingAddress);
        }
    }
}

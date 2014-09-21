using System;
using System.IO;

namespace template_pattern.Shipment
{
    public abstract class OrderShipment
    {
        public string ShippingAddress { get; set; }
        protected string Label { get; set; }

        public void Ship(TextWriter writer)
        {
            VerifyShippingData();
            GetShippingLabelFromCarrier();
            PrintLabel(writer);
        }

        protected virtual void VerifyShippingData()
        {
            if (string.IsNullOrEmpty(ShippingAddress))
            {
                throw new ApplicationException(string.Format("Invalid Address. Shipping Address: {0}", ShippingAddress));
            }
        }

        protected abstract void GetShippingLabelFromCarrier();

        protected virtual void PrintLabel(TextWriter writer)
        {
            writer.Write(Label);
        }
    }
}

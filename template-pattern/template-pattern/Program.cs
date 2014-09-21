using System;
using template_pattern.Shipment;

namespace template_pattern
{
    class Program
    {
        static void Main()
        {
            var upsShipment = new UPSShipment
            {
                ShippingAddress = "Kadikoy Hede Cad. Hebe Sok. Super Apt. K:55/12 Istanbul/Turkey"
            };

            upsShipment.Ship(Console.Out);


            var fedExShipment = new FedExShipment()
            {
                ShippingAddress = "Kadikoy Hede Cad. Hebe Sok. Super Apt. K:55/12 Istanbul/Turkey"
            };

            fedExShipment.Ship(Console.Out);

            Console.ReadKey();
        }
    }
}

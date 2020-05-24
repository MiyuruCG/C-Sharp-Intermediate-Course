using System;

namespace Testability
{
    public class Shipment
    {
        public DateTime DatePlaced { get; set; }
        public float Cost { get; internal set; }
        public DateTime ShippingDate { get; internal set; }
    }
}

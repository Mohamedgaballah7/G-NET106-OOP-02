using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop02
{
    internal class StandardShipment : Shipment
    {
        private string? description1;
        private double weight1;
        private double fee1;

        public StandardShipment(string trackingCode, string? description1, double weight1, double fee1) : base(trackingCode)
        {
            this.description1 = description1;
            this.weight1 = weight1;
            this.fee1 = fee1;
        }

        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override string ToString()
        {
            return "Standard Shipment\n\n" +
                   base.ToString();
        }
    }
}

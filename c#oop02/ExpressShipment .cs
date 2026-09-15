using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop02
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;
        private string? description2;
        private double weight2;
        private double fee2;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public ExpressShipment(string trackingCode, string? description2, double weight2, double fee2) : base(trackingCode)
        {
            this.description2 = description2;
            this.weight2 = weight2;
            this.fee2 = fee2;
        }

        public ExpressShipment(string trackingCode, string? description2, double weight2, double fee2, double extraFee1) : this(trackingCode, description2, weight2, fee2)
        {
            ExtraFee1 = extraFee1;
        }

        public override decimal EstimatedCost => base.EstimatedCost + ExtraFee;

        public double ExtraFee1 { get; }

        public override string ToString()
        {
            return "Express Shipment\n\n" +
                   $"Tracking Code : {TrackingCode}\n" +
                   $"Description   : {Description}\n" +
                   $"Weight        : {Weight} KG\n" +
                   $"Delivery Fee  : {DeliveryFee} EGP\n" +
                   $"Extra Fee     : {ExtraFee} EGP\n" +
                   $"Estimated Cost: {EstimatedCost} EGP";
        }
    }

}

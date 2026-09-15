using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop02
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;

        public string DestinationCountry
        {
            get { 
                return destinationCountry;
            }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        private decimal customsFee;
        private string? description3;
        private double weight3;
        private double fee3;

        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee
            ) : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination
                )
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }

        public InternationalShipment(string trackingCode, string? description3, double weight3, double fee3) : base(trackingCode)
        {
            this.description3 = description3;
            this.weight3 = weight3;
            this.fee3 = fee3;
        }

        public InternationalShipment(string trackingCode, string? description3, double weight3, double fee3, string? destinationCountry, double customsFee1) : this(trackingCode, description3, weight3, fee3)
        {
            this.destinationCountry = destinationCountry;
            CustomsFee1 = customsFee1;
        }

        public decimal CustomsFee
        {
            get { 
                return customsFee; 
            }
            set {
                if (value >= 0)
                    customsFee = value; 
            }
        }

        override public decimal EstimatedCost => base.EstimatedCost + CustomsFee;

        public double CustomsFee1 { get; }

        public override string ToString()
        {
            return "International Shipment\n\n" +
                   $"Tracking Code        : {TrackingCode}\n" +
                   $"Description          : {Description}\n" +
                   $"Weight               : {Weight} KG\n" +
                   $"Delivery Fee         : {DeliveryFee} EGP\n" +
                   $"Destination Country  : {DestinationCountry}\n" +
                   $"Customs Fee          : {CustomsFee} EGP\n" +
                   $"Estimated Cost       : {EstimatedCost} EGP";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop02
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }

        public Shipment(string trackingCode)
        {
            this.trackingCode = "";
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

            TrackingCode = trackingCode;
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            this.trackingCode = "";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }
        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }

        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }
        public void PrintShipment()
        {
            Console.WriteLine("-------all Shipment Details-------");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
        public override string ToString()
        {
            return $"Tracking Code : {TrackingCode}\n" +
                   $"Description   : {Description}\n" +
                   $"Weight        : {Weight} KG\n" +
                   $"Delivery Fee  : {DeliveryFee} EGP\n" +
                   $"Estimated Cost: {EstimatedCost} EGP";
        }
    }
}

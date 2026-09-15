using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop02
{
    public struct DeliveryAddress
    {
        public string city;
        public string street;
        public int buildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.buildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{buildingNumber} {street},{city}. ";
        }

        public override string ToString()
        {
            return GetFullAddress();
        }
    }
}

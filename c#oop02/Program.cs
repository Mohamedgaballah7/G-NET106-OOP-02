namespace c_oop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1:
            #region Q1
            // a-What is the difference between a class and a struct?
            /*
             A class is a reference type, while a struct is a value type, and constructor in struct while intializing the 
            constructor they remove the default constructor but in class we can have default constructor and parameterized constructor.
             */
            //b-Why are classes more suitable than structs for large applications?
            /*
             Classes are more suitable than structs for large applications because they support inheritance, polymorphism, and encapsulation,
            also struct store data in stack memory and class store data in heap memory, so class is more suitable for large applications.
             */
            #endregion
            //QUESTION 2:
            #region Q2
            //a- Which class is the parent class?
            //the parent class is shipment
            //b- Which class is the child class?
            //the child class is ExpressShipment
            //c-What members are inherited by ExpressShipment?
            // trackingCode.
            //d-Why is inheritance better than duplicating the same code in multiple classes?
            // Inheritance allows for code reuse and maintains a clear hierarchy, making the code easier to maintain. 
            #endregion
            //Part 02 : Practical
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter center = new DeliveryCenter(centerName);

            Console.WriteLine();

            Console.WriteLine("--- Standard Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight1 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            double deliveryFee1 = double.Parse(Console.ReadLine());

            StandardShipment standard = new StandardShipment(
                trackingCode1,
                description1,
                weight1,
                deliveryFee1
            );

            Console.WriteLine();

            Console.WriteLine("--- Express Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight2 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            double deliveryFee2 = double.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            double extraFee = double.Parse(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(
                trackingCode2,
                description2,
                weight2,
                deliveryFee2,
                extraFee
            );

            Console.WriteLine();

            Console.WriteLine("--- International Shipment ---");

            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight3 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            double deliveryFee3 = double.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            double customsFee = double.Parse(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(
                trackingCode3,
                description3,
                weight3,
                deliveryFee3,
                destinationCountry,
                customsFee
            );

            Console.WriteLine();

            if (center.AddShipment(standard))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            if (center.AddShipment(express))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            if (center.AddShipment(international))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            Console.WriteLine();

            center.PrintAllShipments();

            Console.WriteLine();

            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found:");
                Console.WriteLine(foundShipment);
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            Console.WriteLine();

            Console.Write("Enter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();

            if (center.RemoveShipment(removeCode))
            {
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            Console.WriteLine();

            center.PrintAllShipments();


        }
    }
}

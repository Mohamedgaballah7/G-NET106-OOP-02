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


        }
    }
}

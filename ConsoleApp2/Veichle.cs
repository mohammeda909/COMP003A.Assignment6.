namespace COMP003A.Assignment6
{
    /// <summary>
    /// Abstracts describe a contract but does not provide a full implementaiton of the contract.
    /// Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    abstract class Vehicle : IVehicle
    {
        /* fields section */
        // note: in almost all programming languages, you would typically pair a field with a property
        // this is not a requirement in C# because it offers auto-property
        private string _brand;
        private string _model;
        private int _numberOfWheels;

        /* constructors section */
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// Constructor that takes three parameters: brand, model, numberOfWheels
        /// </summary>
        /// <param name="brand">String input for brand name</param>
        /// <param name="model">String input for model name</param>
        /// <param name="numberOfWheels">Integer input for number of wheels</param>
        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        /* properties section */
        /// <summary>
        /// Retrieve/Store Brand information
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// Retrieve/Store Model information
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// Retrive/Store Number of Wheels Information
        /// </summary>
        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set { _numberOfWheels = value; }
        }

        /* methods section */
        /// <summary>
        /// Prints the Brand, Model, and Number of Wheels information
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
    }
}

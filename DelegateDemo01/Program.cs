namespace DelegateDemo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car{Brand = "Volvo", Model = "XC90", YearOfManufacture = 2023, LicenseNumber = "ABC 123" },
                new Car{Brand = "SAAB", Model = "9-5", YearOfManufacture = 1999, LicenseNumber = "SAA 345" },
                new Car{Brand = "Volkswagen", Model = "Golf", YearOfManufacture = 2002, LicenseNumber = "GOL 888" },
                new Car{Brand = "Toyota", Model = "Ayog Hybrid", YearOfManufacture = 2021, LicenseNumber = "TOY 111" }
            };

            cars.Sort(CompareByYearOfManufacture);
            cars.Sort(CompareByBrand);
            //Det som skrivs i metoden, mellan paranteserna kallar håkan ARGUMENT
            //Ser man ist static void DoSomething(string Name) då är det PARAMETER som är inom paranteserna.
            //LINQ  compare and OrderBy

            cars = cars.OrderBy(CompareDataValue).ToList();
        }

        static string CompareDataValue(Car c)
        {
            return c.LicenseNumber;
        }
        static int CompareByBrand(Car a, Car b)  // -1 bil a före bil b. 0 = bil a och bil b lika. 1bil b före bil a
        {
            return string.Compare(a.Brand, b.Brand);
        }

        static int CompareByYearOfManufacture(Car a, Car b) // -1 bil a före bil b. 0 = bil a och bil b lika. 1bil b före bil a
        {
            if (a.YearOfManufacture < b.YearOfManufacture)
                return -1;
            else
                if (a.YearOfManufacture > b.YearOfManufacture)
                return 1;

            return 0;
        }
    }
}

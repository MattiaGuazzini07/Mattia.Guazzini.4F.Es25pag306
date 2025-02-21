namespace Mattia.Guazzini._4F.Es25pag306;

class Program
{
    static void Main(string[] args)
    {
        Pharmacy pharmacy = new Pharmacy("Guazzini's pharmacy", 2); // Create a new pharmacy
        Medicinal medicinal1 = new Medicinal("Guazzini's pharmacy", 2, 120, "Drugs"); // Create a new medicinal
        pharmacy.AddMedicinal(medicinal1); // Add the medicinal to the pharmacy
        Medicinal medicinal2 = new Medicinal("Guazzini's pharmacy", 2, 150, "Pills"); // Create a new medicinal
        pharmacy.AddMedicinal(medicinal2); // Add the medicinal to the pharmacy

        Console.WriteLine(pharmacy.ToString()); // Print the pharmacy description
        
        //Print the low cost's medicinal
        Console.WriteLine("The low cost's medicinal is: ");
        double min = Double.MaxValue;
        foreach (Medicinal medicinal in pharmacy.Medicinals)
        {
            if (medicinal.MedicinalPrice < min)
            {
                min = medicinal.MedicinalPrice;
            }
        }
        
        //Print pharmacy's total price and pharmacy's name
        Console.WriteLine($"The total price of the pharmacy is: {pharmacy.TotalPrice()}");
        Console.WriteLine($"The pharmacy's name is: {pharmacy.Name}");
        
        //Print the price of a specific medicinal
        Console.WriteLine("Insert a medicinal name to get the price");
        string medicinalName = Console.ReadLine();
        Console.WriteLine($"The price of {medicinalName} is {pharmacy.MedicinalPrice(medicinalName)}");
    }
}
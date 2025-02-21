namespace Mattia.Guazzini._4F.Es25pag306;

public class Pharmacy
{
    public string Name { get; set; } // Name of the pharmacy
    public int NMedicinals { get; set; } // Number of medicinals
    List<Medicinal> Medicinals { get; set; } // List of medicinals
    
    public Pharmacy(string name, int nMedicinals) // Constructor
    {
        Name = name;
        NMedicinals = nMedicinals;
        Medicinals = new List<Medicinal>();
    }
    
    public void AddMedicinal() // Add a medicinal to the list
    {
        Console.WriteLine("Which is the name of the medicinal?");
        string medicinalName = Console.ReadLine();
        Console.WriteLine("Which is the price of the medicinal?");
        double medicinalPrice = Double.Parse(Console.ReadLine());
        Medicinals.Add(new Medicinal(Name, NMedicinals, medicinalPrice, medicinalName));
    }

    public double TotalPrice() // Calculate the total price of all the medicinals
    {
        double totalPrice = 0;
        foreach (Medicinal medicinal in Medicinals)
        {
            totalPrice += medicinal.MedicinalPrice;
        }
        return totalPrice;
    }
    
    public double MedicinalPrice(string medicinalName) // Return the price of a specific medicinal
    {
        foreach (Medicinal medicinal in Medicinals)
        {
            if (medicinal.MedicinalName == medicinalName)
            {
                return medicinal.MedicinalPrice;
            }
        }
        return 0;
    }

    public override string ToString() // Return the name of the pharmacy and the number of medicinals
    {
        return $"Name: {Name}, Medicinals number: {NMedicinals}";
    }
}

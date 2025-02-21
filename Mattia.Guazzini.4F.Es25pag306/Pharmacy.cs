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
    /// <summary>
    /// User add a new medicinal to the list
    /// </summary>
    /// <param name="medicinalName"></param>
    /// <param name="medicinalPrice"></param>
    public void AddNewMedicinal()
    {
        Console.WriteLine("Which is the name of the medicinal?");
        string medicinalName = Console.ReadLine();
        Console.WriteLine("Which is the price of the medicinal?");
        double medicinalPrice = Double.Parse(Console.ReadLine());
        Medicinals.Add(new Medicinal(Name, NMedicinals, medicinalPrice, medicinalName));
    }
    /// <summary>
    /// Add a ready medicinal to the list
    /// </summary>
    /// <param name="medicinal">ready medicinal</param>
    public void AddMedicinal(Medicinal medicinal) => Medicinals.Add(medicinal);
    /// <summary>
    /// Calculate the total price of all the medicinals
    /// </summary>
    /// <returns></returns>
    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (Medicinal medicinal in Medicinals)
        {
            totalPrice += medicinal.MedicinalPrice;
        }
        return totalPrice;
    }
    /// <summary>
    /// Return the price of a specific medicinal
    /// </summary>
    /// <param name="medicinalName"></param>
    /// <returns></returns>
    public double MedicinalPrice(string medicinalName)
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
    /// <summary>
    /// Description of the object
    /// </summary>
    /// <returns></returns>
    public override string ToString() 
    {
        return $"Name: {Name}, Medicinals number: {NMedicinals}";
    }
}

namespace Mattia.Guazzini._4F.Es25pag306;

public class Medicinal : Pharmacy
{
    public string MedicinalName { get; set; } // Name of the medicinal
    public double MedicinalPrice { get; set; } // Price of the medicinal
    public Medicinal(string name, int nMedicinals, double medicinalPrice, string medicinalName) : base(name, nMedicinals) // Constructor
    {
        MedicinalPrice = medicinalPrice;
        MedicinalName = medicinalName;
    }
    /// <summary>
    /// Description of the object
    /// </summary>
    /// <returns>Description string</returns>
    public override string ToString()
    {
        return $"Name: {Name}, Medicinals number: {NMedicinals}, Price: {MedicinalPrice}";
    }
}
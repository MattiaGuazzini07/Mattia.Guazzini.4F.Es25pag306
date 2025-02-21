namespace Mattia.Guazzini._4F.Es25pag306;

public class Medicinal : Pharmacy
{
    public string MedicinalName { get; set; }
    public double MedicinalPrice { get; set; }
    public Medicinal(string name, int nMedicinals, double medicinalPrice, string medicinalName) : base(name, nMedicinals)
    {
        MedicinalPrice = medicinalPrice;
        MedicinalName = medicinalName;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Medicinals number: {NMedicinals}, Price: {MedicinalPrice}";
    }
}
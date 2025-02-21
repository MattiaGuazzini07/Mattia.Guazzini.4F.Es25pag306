namespace Mattia.Guazzini._4F.Es25pag306;

public class Pharmacy
{
    public string Name { get; set; }
    public int NMedicinals { get; set; }
    List<Medicinal> Medicinals { get; set; }
    
    public Pharmacy(string name, int nMedicinals)
    {
        Name = name;
        NMedicinals = nMedicinals;
        Medicinals = new List<Medicinal>();
    }
}
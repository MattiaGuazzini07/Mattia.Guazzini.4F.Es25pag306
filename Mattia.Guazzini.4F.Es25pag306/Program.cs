namespace Mattia.Guazzini._4F.Es25pag306;

class Program
{
    static void Main(string[] args)
    {
        Pharmacy pharmacy = new Pharmacy("Guazzini's pharmacy", 2);
        Medicinal medicinal = new Medicinal("Guazzini's pharmacy", 2, 120, "Drugs");
        pharmacy.AddMedicinal(medicinal);
        Medicinal medicinal2 = new Medicinal("Guazzini's pharmacy", 2, 150, "Pills");
        pharmacy.AddMedicinal(medicinal2);

        Console.WriteLine(pharmacy.ToString());
    }
}
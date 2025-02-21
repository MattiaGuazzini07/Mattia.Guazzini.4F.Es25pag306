namespace Mattia.Guazzini._4F.Es25pag306;

class Program
{
    static void Main(string[] args)
    {
        Pharmacy pharmacy = new Pharmacy("Farmacia Guazzini", 10);
        Medicinal medicinal = new Medicinal("Farmacia Guazzini", 10, 10.5, "Aspirina");

        Console.WriteLine(pharmacy.ToString());
    }
}
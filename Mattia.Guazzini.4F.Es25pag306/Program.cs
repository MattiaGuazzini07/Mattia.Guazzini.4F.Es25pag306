namespace Mattia.Guazzini._4F.Es25pag306;

class Program
{
    static void Main(string[] args)
    {
        Pharmacy pharmacy = new Pharmacy("Farmacia Guazzini", 10);
        pharmacy.AddMedicinal();

        Console.WriteLine(pharmacy.ToString());
    }
}
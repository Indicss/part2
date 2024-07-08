using System;

public class Angajat
{
    public string Nume { get; set; }
    public decimal Salariu { get; set; }
    public string Departament { get; set; }

    public Angajat(string nume, decimal salariu, string departament)
    {
        Nume = nume;
        Salariu = salariu;
        Departament = departament;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"Nume: {Nume}, Salariu: {Salariu}, Departament: {Departament}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Angajat angajat1 = new Angajat("Ion Popescu", 3000, "IT");
        Angajat angajat2 = new Angajat("Maria Ionescu", 3500, "HR");

        angajat1.AfisareDetalii();
        angajat2.AfisareDetalii();
    }
}

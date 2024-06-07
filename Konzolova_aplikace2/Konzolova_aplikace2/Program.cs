using System;

public class ComplexNumber
{
    // public atributy pro reál a imaginary část komplexního čísla
    public double Real { get; set; }
    public double Imaginary { get; set; }

    // Konstruktor pro inicializaci komplexního čísla
    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Metoda pro sčítání dvou komplexních čísel
    public ComplexNumber Plus(ComplexNumber other)
    {
        return new ComplexNumber(this.Real + other.Real, this.Imaginary + other.Imaginary);
    }

    // Metoda pro odčítání dvou komplexních čísel
    public ComplexNumber Minus(ComplexNumber other)
    {
        return new ComplexNumber(this.Real - other.Real, this.Imaginary - other.Imaginary);
    }

    // Přetížená metoda ToString pro snadné zobrazení komplexního čísla ve formátu "a + bi"
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        // Požádáme uživatele o zadání prvního komplexního čísla
        Console.WriteLine("Zadejte první komplexní číslo.");
        Console.Write("Reálná část: ");
        double real1 = Convert.ToDouble(Console.ReadLine());        // Načtení reálné části
        Console.Write("Imaginární část: ");
        double imaginary1 = Convert.ToDouble(Console.ReadLine());   // Načtení imaginární části

        // Vytvoření instance ComplexNumber pro první komplexní číslo
        ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);

        // Požádáme uživatele o zadání druhého komplexního čísla
        Console.WriteLine("Zadejte druhé komplexní číslo.");
        Console.Write("Reálná část: ");
        double real2 = Convert.ToDouble(Console.ReadLine());        // Načtení reálné části
        Console.Write("Imaginární část: ");
        double imaginary2 = Convert.ToDouble(Console.ReadLine());   // Načtení imaginární části

        // Vytvoření instance ComplexNumber pro druhé komplexní číslo
        ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);

        // Výpočet součtu, rozdílu, součinu a podílu dvou komplexních čísel
        ComplexNumber sum = complex1.Plus(complex2);
        ComplexNumber difference = complex1.Minus(complex2);

        // Výpis výsledků do konzole
        Console.WriteLine($"\nSoučet: {sum}");
        Console.WriteLine($"Rozdíl: {difference}");
        Console.ReadLine();
    }
}

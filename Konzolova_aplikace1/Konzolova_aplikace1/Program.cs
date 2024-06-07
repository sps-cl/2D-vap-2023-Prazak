using System;
using System.Linq;

namespace Konzolova_aplikace1
{
    class Program 
    {
        static void Main(string[] args) 
        {
            while (true) // While cyklus
            {
                string input = Console.ReadLine(); 

                try 
                {
                    // Rozdělení vstupu podle čárek a převod na pole celých čísel.
                    int[] numbers = input.Split(',').Select(int.Parse).ToArray();

                    // Zjištění nejměnšího, největšího čísla a délky nejdelšího vzestupného intervalu.
                    int min = numbers.Min();
                    int max = numbers.Max();
                    int SequenceLength = GetSequenceLength(numbers);

                    // Výpis výsledků.
                    Console.WriteLine($"Nejmenší číslo je {min}.");
                    Console.WriteLine($"Největší číslo je {max}.");
                    Console.WriteLine($"Délka nejdelšího vzestupného intervalu je {SequenceLength}.");
                }
                catch (FormatException) // Ošetření výjimky, která nastane, pokud vstup obsahuje neplatné znaky.
                {
                    Console.WriteLine("Chyba: Zadávejte pouze celá čísla oddělená čárkou.");
                }

                Console.WriteLine();
            }
        }

        // Metoda pro zjištění délky nejdelšího vzestupného intervalu v poli čísel.
        static int GetSequenceLength(int[] numbers)
        {
            int maxLength = 0; 
            int currentLength = 1; 

            for (int i = 1; i < numbers.Length; i++) 
            {
                if (numbers[i] > numbers[i - 1]) 
                {
                    //Zvýšení délky aktuálního intervalu a aktualizace maximální délky.
                    currentLength++; 
                    maxLength = Math.Max(maxLength, currentLength); 
                }
                else
                {
                    currentLength = 1; // Resetování aktuální délky intervalu.
                }
            }

            return maxLength;
        }
    }
}


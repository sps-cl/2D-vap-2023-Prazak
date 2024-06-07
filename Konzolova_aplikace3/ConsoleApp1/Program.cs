namespace _3UKOL
{
    class Slovnik
    {
        private List<string> slova;     //Určení datový struktury pro uchování přidaných slov
        private int index;          //vytvoření indexu = index aktuálně zobrazeného slova


        public Slovnik()
        {
            slova = new List<string>();     //Inicializace seznamu
            index = -1;         
        }

        public void PridatSlovo(string slovo)
        {
            slova.Add(slovo);           //Přída slovo do seznamu
            index = slova.Count - 1;
            Console.WriteLine(slovo);       //Vypíše zadané slovo do konzole
        }

        public void Zpet()
        {
            if (index > 0)  //pokud je index větší než 0, je teda v seznamu dva a více slov, vypíše slovo před aktualním slovem
            {
                index--;
                Console.WriteLine(slova[index]);
            }
            else
            {
                Console.WriteLine(slova[0]);        //jinak vypíše první slovo
            }
        }

        public void Vpred()
        {
            if (index < slova.Count - 1)          //pokud je počet přidaných slov větší nežindex = pořadí aktualního slova, napíše další slovo v pořadí
            {
                index++;
                Console.WriteLine(slova[index]);
            }
            else
            {
                Console.WriteLine(slova[slova.Count - 1]); //jinak napíše poslední přidané slovo
            }
        }
    }

    class Program
    {
        static void ZpracujPrikaz(Slovnik slovnik, string prikaz)   //volání metod/příkazů přidat,zpět,vpřed a neznámý příkaz
        {
            if (prikaz.StartsWith("Pridat:"))
            {
                string slovo = prikaz.Substring(7);
                slovnik.PridatSlovo(slovo);
            }
            else if (prikaz == "Zpet")
            {
                slovnik.Zpet();
            }
            else if (prikaz == "Vpred")
            {
                slovnik.Vpred();
            }
            else
            {
                Console.WriteLine("Neznamy prikaz");
            }
        }
        static void Main(string[] args)
        {
            Slovnik slovnik = new Slovnik();    //vytvoření instance
            while (true)
            {
                string prikaz = Console.ReadLine();     //Přečtení a zpracování příkazu od uživatele
                ZpracujPrikaz(slovnik, prikaz);
            }
        }
    }
}

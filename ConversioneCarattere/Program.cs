using System;

namespace ConversioneCarattere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci una lettera di cui vuoi sapere in numero in ASCII");
            char car = Convert.ToChar(Console.ReadLine());
            ushort carASCII = 0;
            carASCII = car;
            string n = Convert.ToString(carASCII, 2).PadLeft(16, '0');
            Console.WriteLine($"Carattere {car} - Carattere in ASCII {carASCII} - NumeroBinario {n}");

        }
    }
    
}

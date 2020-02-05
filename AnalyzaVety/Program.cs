/*
 * Created by SharpDevelop.
 * User: Peki
 * Date: 11.11.2019
 * Time: 21:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AnalyzaVety
{
	class Program
    {
        public static string samohlasky = "aeiouáéíóú";
        public static string souhlasky = "bcčdďfghjklmnňoprřsštťvzž";
        public static string c = "";
        public static int pocetSouhlasky = 0;
        public static int pocetSamohlasky = 0;

        public static string[] prislovi = new string[]
            {
                "Když se dva perou, třetí se směje.",
                "Co se v mládí naučíš, v stáří jako když najdeš.",
                "Co je šeptem, to je s čertem.",
                "Rychlé nohy, krátký rozum.",
                "Komu není rady, tomu není pomoci.",
            };
        public static void Main(string[] args)
        {
           
            string losuj = "ano";
            while (losuj == "ano")
            {
               Console.WriteLine(">>>Analýza věty<<<");
               Console.WriteLine();
               VyberZPole();
               ProjdiZnaky();
               Vypis();
               Console.Clear();
            }
        }
        public static void VyberZPole()
        {
            Random rnd = new Random();
            int[] pole = new int[5];
            for (int i = 0; i < 1; i++)
            {
                pole[i] = rnd.Next(0, 5);
                int a = pole[i];
                c = prislovi[a];
                Console.WriteLine(c);
                c = c.ToLower();
            }
        }
        public static void ProjdiZnaky()
        {
            foreach (char znak in c)
            {
                if (samohlasky.Contains(znak.ToString()))
                {
                    pocetSamohlasky++;
                }
                else if (souhlasky.Contains(znak.ToString()))
                {
                    pocetSouhlasky++;
                }
            }
        }
        public static void Vypis()
        {
            string[] slova = c.Split(' ');
            Console.WriteLine("Pocet slov je: {0}", slova.Length);
            Console.WriteLine("Pocet samohlasek je: {0} ", pocetSamohlasky);
            Console.WriteLine("Pocet souhlasek je: {0} ", pocetSouhlasky);
            Console.WriteLine("Pocet ostatnich znaku je: {0} ", c.Length - (pocetSouhlasky + pocetSamohlasky));
            Console.WriteLine("Celkovy pocet znaku je: {0} ", c.Length);
            Console.WriteLine();
            pocetSamohlasky = 0;
            pocetSouhlasky = 0;
            Console.WriteLine("Klávesou pokračuj...");
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
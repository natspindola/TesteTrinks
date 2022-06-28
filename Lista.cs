using System;
using System.Collections.Generic;
using TesteTrinks;

namespace Lista
{
        public class Program
        {
            static List<Lugares> lugar;
            static List<Lugares> lugarM;

            static void Main(string[] args)
            {
                lugar = new List<Lugares>();
                lugar.Add(new Lugares(10000, "Fernando de Noronha"));
                lugar.Add(new Lugares(8500, "Amazônia"));
                lugar.Add(new Lugares(8000, "Chapada Diamantina"));
                lugar.Add(new Lugares(5500, "Serras Gauchas"));
                lugar.Add(new Lugares(4200, "Brasília"));
                Console.WriteLine("Lugares para viajar no Brasil:");
                foreach (Lugares p in lugar)
                {
                    Console.WriteLine(p.Nome + " - " + p.Valor + " reais");
                }

                Console.WriteLine();

                lugarM = new List<Lugares>();
                lugarM.Add(new Lugares(3000, "Buenos Aires"));
                lugarM.Add(new Lugares(6800, "Casa Blanca"));
                lugarM.Add(new Lugares(7000, "Cairo"));
                lugarM.Add(new Lugares(7000, "Qebec"));
                lugarM.Add(new Lugares(4200, "Havaí"));
                Console.WriteLine("Lugares para viajar no Mundo:");
                foreach (Lugares p in lugarM)
                {
                Console.WriteLine(p.Nome + " - " + p.Valor + " reais");
                }
                Console.ReadKey();
            }
        }
}
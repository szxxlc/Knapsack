using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]
namespace ProblemPlecakowy
{
    class Problem
    {
        private List<Przedmiot> Przedmioty { get; set; } // lista przedmiotów
        private int N;

        // generowanie instancji problemu
        public Problem(int n, int seed)
        {
            Random random = new(seed);
            Przedmioty = new List<Przedmiot>();

            int maxWartosc = 10;
            int maxWaga = 10;

            for (int i = 0; i < n; i++)
            {
                Przedmioty.Add(new Przedmiot(i+1, random.Next(1, maxWartosc + 1), random.Next(1, maxWaga + 1)));
                // wypisanie wygenerowanych przedmiotów
                Console.WriteLine($"Przedmiot {Przedmioty[i].GetId()}: wartość = {Przedmioty[i].GetWartosc()}, waga = {Przedmioty[i].GetWaga()}");
            }

            N = n;
        }

        public Problem(int n)
        {
            int seed = 0;
            Random random = new(seed);
            Przedmioty = new List<Przedmiot>();

            int maxWartosc = 10;
            int maxWaga = 10;

            for (int i = 0; i < n; i++)
            {
                Przedmioty.Add(new Przedmiot(i + 1, random.Next(1, maxWartosc + 1), random.Next(1, maxWaga + 1)));
                // wypisanie wygenerowanych przedmiotów
                Console.WriteLine($"Przedmiot {Przedmioty[i].GetId()}: wartość = {Przedmioty[i].GetWartosc()}, waga = {Przedmioty[i].GetWaga()}");

            }

            N = n;
        }

        // zwracanie instancji problemu jako string
        public override string ToString()
        {
            string output = $"Liczba przedmiotów: {N}\n";
            for (int i = 0; i < N; i++)
            {
                output += $"Przedmiot {Przedmioty[i].GetId()}: wartość = {Przedmioty[i].GetWartosc()}, waga = {Przedmioty[i].GetWaga()}\n";
            }
            return output;
        }

        public Result Solve(int capacity)
        {
            Result result = new Result();

            // sprawdzenie czy została wygenerowana instancja problemu
            if (Przedmioty.Count == 0)
            {
                return result;
            }

            // posortowanie przedmiotów po stosunku wartości do wagi
            List<Przedmiot> sorted = Przedmioty.OrderByDescending(p => (double)p.GetWartosc() / p.GetWaga()).ToList();

            // wypisanie posortowanych przedmiotów
            Console.WriteLine("\n Posortowane przedmioty po stosunku wartości do wagi:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Przedmiot {sorted[i].GetId()}: wartość = {sorted[i].GetWartosc()}, waga = {sorted[i].GetWaga()}");
            }

            // umieszczanie przedmiotów w plecaku dopóki się mieszczą
            for (int i = 0; i < N; i++)
            {
                if (capacity >= sorted[i].GetWaga())
                {
                    result.DodajPrzedmiot(sorted[i].GetId(), sorted[i].GetWartosc(), sorted[i].GetWaga());
                    capacity -= sorted[i].GetWaga();
                }
            }

            return result;
        }

        public List<Przedmiot> GetPrzedmioty()
        {
            return Przedmioty;
        }
        public int GetN()
        {
            return N;
        }
    }
}

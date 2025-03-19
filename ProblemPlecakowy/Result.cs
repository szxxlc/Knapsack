using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    class Result
    {
        private List<int> Przedmioty; // lista numerów (id) przedmiotów w plecaku
        private int SumarycznaWartosc;
        private int SumarycznaWaga;

        public Result()
        {
            Przedmioty = new List<int>();
            SumarycznaWartosc = 0;
            SumarycznaWaga = 0;
        }
        public void DodajPrzedmiot(int id, int wartosc, int waga)
        {
            Przedmioty.Add(id);
            SumarycznaWartosc += wartosc;
            SumarycznaWaga += waga;
        }

        public override string ToString()
        {
            string output = "Przedmioty w plecaku: ";
            for (int i = 0; i < Przedmioty.Count; i++)
            {
                output += $"{Przedmioty[i]} ";
            }
            return $"{output} \nSumaryczna wartość: {SumarycznaWartosc} \nSumaryczna waga: {SumarycznaWaga}";
        }

        public List<int> GetPrzedmioty()
        {
            return Przedmioty;
        }
        public int GetSumarycznaWartosc()
        {
            return SumarycznaWartosc;
        }
        public int GetSumarycznaWaga()
        {
            return SumarycznaWaga;
        }
    }
}

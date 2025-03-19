using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    class Przedmiot
    {
        private int Id; // numer przedmiotu
        private int Wartosc; // wartość przedmiotu
        private int Waga; // waga przedmiotu

        public Przedmiot()
        {
            this.Id = 1;
            this.Wartosc = 0;
            this.Waga = 1;
        }

        public Przedmiot(int id, int wartosc, int waga)
        {
            this.Id = id;
            this.Wartosc = wartosc;
            this.Waga = waga;
        }

        public int GetId()
        {
            return Id;
        }
        public int GetWartosc()
        {
            return Wartosc;
        }
        public int GetWaga()
        {
            return Waga;
        }
    }
}

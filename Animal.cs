using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_I_Lab
{
    abstract class Animal : IComparable
    {
        //hola
        //chau
        public int PasosParaMorir { get; private set; }
        public int TiempoSinComer { get; private set; }
        public int PasosVividos { get; private set; }
        public int Vidas { get; private set; }

        abstract public void Mover();
        abstract public void Comer();
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

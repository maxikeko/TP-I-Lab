using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_I_Lab
{
    internal class Gato : Animal
    {
        public int RatonesMatados { get; private set; }
        public override void Comer()
        {
            throw new NotImplementedException();
        }

        public override void Mover()
        {
            throw new NotImplementedException();
        }
    }
}

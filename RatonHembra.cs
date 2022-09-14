using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_I_Lab
{
    internal class RatonHembra: RatonMacho
    {
        public bool Embarazo { get; private set; }
        private int tiempoGestacion = 0;

        public override void Mover()
        {
            base.Mover();

            if (Embarazo == true)
                Gestar();
        }

        private void Gestar()
        { 
            tiempoGestacion++;
            if (tiempoGestacion >= 10)
            {
                Parir();

            }
        }

        private void Parir()
        {
            
        }
    }
}

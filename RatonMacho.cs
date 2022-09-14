using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_I_Lab
{
    internal class RatonMacho: Animal
    {
        public string MuertoPor { get; private set; }
        public string Genero { get; private set; }
        public int Saciedad { get; private set; }
        public bool Fertil { get; private set; }

        private IslaSoloRatones isla;

        public override void Comer()
        {
            throw new NotImplementedException();
        }

        public override void Mover()
        {
        //    int mover;

            ////Diresccion

            ////Desplazamiento - 0 +



            //if (mover < 0 || mover > limite)
            //{
            //    //Moriria
            //}
            //else
            //{ 
            //    //Se movería
            //}
        }

        virtual public void Reproducir()
        { 
            
        }
    }
}

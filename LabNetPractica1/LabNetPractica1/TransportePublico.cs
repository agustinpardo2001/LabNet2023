using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public abstract class TransportePublico 
    {
        public int Pasajeros;
            public TransportePublico(int pasajeros)
            {
                this.Pasajeros = pasajeros;
            }
            public int getPasajeros { get => Pasajeros; set => Pasajeros = value; }

            public abstract int AgregarPasajeros(int pasajeros);
            public abstract void EliminarPasajeros();
            public abstract string Avanzar();
            public abstract string Detenerse();


        
    }
}

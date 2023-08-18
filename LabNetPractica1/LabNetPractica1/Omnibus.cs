using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Omnibus : TransportePublico
    {
        public int Linea { get; set; }

        public Omnibus(int Pasajeros, int linea) : base(Pasajeros)
        {
            this.Linea = linea;
        }
        public override int AgregarPasajeros(int pasajeros)
        {
            return pasajeros += pasajeros;
        }
        public override void EliminarPasajeros()
        {
           Pasajeros = 0;
        }
        public override string Avanzar()
        {
            return "";
        }
        public override string Detenerse()
        {
            return "";
        }

    }  }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Taxi : TransportePublico
    {
        public string Coche { get; set; }
        public Taxi(int Pasajeros, string Coche) : base(Pasajeros)
        {
            this.Coche = Coche;
        }

        public override int AgregarPasajeros(int pasajeros)
        {
            return Pasajeros += pasajeros;
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
    }   }

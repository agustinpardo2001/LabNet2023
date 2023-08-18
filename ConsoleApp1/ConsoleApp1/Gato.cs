using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppPOO
{
    public class Gato : Animal
    {
        public Gato(int canPatas) : base(canPatas)
        {
        }
        public override string Caminar()
        {
            return $"Soy un Gato y camino con {getPatas} patas";
        }
    }
}


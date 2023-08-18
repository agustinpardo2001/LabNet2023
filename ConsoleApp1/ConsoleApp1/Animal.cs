using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppPOO
{
    public abstract class Animal
    {
        public Animal(int canPatas) 
        {
            getPatas = canPatas;
        }

        public int getPatas { get; }

        public abstract string Caminar();


    }
}

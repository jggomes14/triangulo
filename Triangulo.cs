using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    internal class Triangulo
    {
        public double ladox;
        public double ladoy;
        public double ladoz;

        public bool TrianguloValido()
        {
            return (ladox + ladoy > ladoz) && (ladox + ladoz > ladoy) && (ladoy + ladoz > ladox);
        }

        public bool Equilatero()
        {
            return TrianguloValido() && (ladox == ladoy && ladoy == ladoz);
        }

        public bool Isosceles()
        {
            return TrianguloValido() && (ladox == ladoy || ladox == ladoz || ladoy == ladoz);
        }

        public bool Escaleno()
        {
            return TrianguloValido() && !Equilatero() && !Isosceles();
        }
    }

}

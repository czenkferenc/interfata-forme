using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfata_forme
{
    class Cerc : IForma2D
    {
        private double raza;

        public Cerc(double r)
        {
            raza = r;
        }

        public string Denumire
        {
            get { return "Cerc"; }
        }

        public double Arie()
        {
            return Math.PI * raza * raza;
        }

        public double LungimeaFrontierei()
        {
            return 2 * Math.PI * raza;
        }
    }
}

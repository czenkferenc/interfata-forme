using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfata_forme
{
    class Patrat : IForma2D
    {
        private double latura;

        public Patrat(double l)
        {
            latura = l;
        }

        public double Arie()
        {
            return latura * latura;
        }

        public double LungimeaFrontierei()
        {
            return 4 * latura;
        }

        public string Denumire
        {
            get { return "Patrat"; }
        }

    }
}

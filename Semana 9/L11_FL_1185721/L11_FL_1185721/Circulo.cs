using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_FL_1185721
{
    internal class Circulo
    {
        private double radio;
        double Perimetro, Area, Volumen;

  



        private void ObtenerPerimetro()
        {
            Perimetro = 2 * radio * 3.1416;
        }

        private void ObtenerArea()
        {
            Area = 3.1416 * (radio * radio);

        }



        private void ObtenerVolumen()
        {
            Volumen = 4 * 3.1416 * (radio * radio * radio) / 3;
        }

        public string CalcularGeometria()
        {
            double unPerimetro, unArea, unVolumen;

            unPerimetro = Perimetro;
            unArea = Area;
            unVolumen = Volumen;

            return " perimetro: " + unPerimetro + " Area: " + unArea + " Volumen: " + unVolumen;
        }

    }

}

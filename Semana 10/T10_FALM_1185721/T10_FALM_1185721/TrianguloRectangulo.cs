using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_FALM_1185721
{
    class TrianguloRectangulo
    {
        public double catetoA, anguloOpuestoA;


        public double ObetenerCatetoB()
        {
            return catetoA / Math.Tan(anguloOpuestoA); //Radianes//

        }

        public double ObtenerHipotenusa()
        {
            return catetoA / Math.Sin(anguloOpuestoA);


         }
        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }
        public double Obtenerarea()
        {
            return catetoA * ObetenerCatetoB() / 2;       }

    }
}

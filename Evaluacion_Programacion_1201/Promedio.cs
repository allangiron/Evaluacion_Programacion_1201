using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Programacion_1201
{
    class Promedio
    {
        private string nombre;
        private long cuenta;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;
        private int promedio;
        private string iteracion;

        public String Nombre { get; set; }
        public long Cuenta { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        public int Promedio1
        {
            get { promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
                  return promedio;
            }
            set { promedio = value; }
        }

        public string Iteracion
        {
            get
            {
                if (promedio >= 70)
                {
                    iteracion = " Felicidades Usted Aprobo La Clase ";
                }

                if (promedio < 70)
                {
                    iteracion = " Lo Sentimos, Ha Reprobado La Clase ";
                }
                return iteracion;
            }
        }

    }
}

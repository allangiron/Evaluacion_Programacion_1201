using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_Programacion_1201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_obtenerPromedio_Click(object sender, EventArgs e)
        {
            Promedio estudiante = new Promedio();
            estudiante.Nombre = Txt_nombre.Text;
            estudiante.Cuenta = Convert.ToInt64(Txt_cuenta.Text);
            estudiante.Nota1 = Convert.ToInt32(Txt_nota1.Text);
            estudiante.Nota2 = Convert.ToInt32(Txt_nota2.Text);
            estudiante.Nota3 = Convert.ToInt32(Txt_nota3.Text);
            estudiante.Nota4 = Convert.ToInt32(Txt_nota4.Text);

            MessageBox.Show(" Nombre Del Estudiante: " + estudiante.Nombre);
            MessageBox.Show(" El Numero De Cuenta Es: " + estudiante.Cuenta);
            MessageBox.Show(" Promedio Final: " + estudiante.Promedio1);
            MessageBox.Show(estudiante.Iteracion);

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_nombre.Clear();
            Txt_cuenta.Clear();
            Txt_nota1.Clear();
            Txt_nota2.Clear();
            Txt_nota3.Clear();
            Txt_nota4.Clear();
        }
    }
}

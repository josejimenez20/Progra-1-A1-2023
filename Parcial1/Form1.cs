using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConvertirConversores_Click_1(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de = cboDeConversores.SelectedIndex;
            a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversores.Text);

            double[] medida = { 0.09290304, 0.698896, 0.836127, 1, 438, 7000, 10000, };

            respuesta = medida[de] / medida[a] * cantidad;
            // Trajabe individual en el  Funcionalidad del conversor de Área (Superficie) 
            //Estudiante: Jose Heinar Jimenez Reyes USSS040123
            lblRespuestaConversores.Text = " Respuesta " + Math.Round(respuesta, 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores
{
    public partial class Form1 : Form
    {
        String[][] TipoDeConversores = new String[][]{
          new String[]{"Dolar", "Euro", "Quetzal", "Lempira", "Cordoba", "ColonSV", "ColonCR", "Yenes", "Rupias india", "Libras esterlinas"},
          new String[]{"Libra", "Kilogramo", "Gramo", "Tonelada", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada Corta", "Stone", "Onza"},
          new String[]{"Litro", "Galon USA", "Cuarto USA", "Pinta USA", "Taza USA", "Onza liquida USA", "Cucharada USA", "Cucharadita USA", "Metro Cubico", "Mililitro"},
          new String[]{"Metro", "Kilometro", "Centimetro", "Milimetro", "Micrometro", "Nanometro", "Milla", "Yarda", "Pie", "Pulgada"},
          new String[]{"Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Kilobyte", "Byte", "Petabit", "Terabit", "Gigabit", "Megabit"},
          new String[]{"Minuto", "Segundo", "Hora", "Dia", "Semana", "mes", "Año", "Decada", "Siglo", "Milisegundo"},

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            {
                int de, a;
                double cantidad, respuesta;

                de = cboDeConversores.SelectedIndex;
                a = cboAConversores.SelectedIndex;

                cantidad = double.Parse(txtCantidadConversores.Text);

                double[][] monedas = {
                new double[]{1, 0.92, 7.86, 24.62, 36.56, 8.75, 535.14, 145.52, 83.32, 0.79 },
                new double[]{1, 0.453592, 453.592, 0.000453592, 453592, 453600000, 0.000446429, 0.0005, 0.0714286, 16},
                new double[]{1, 0.264172, 1.05669, 2.11338, 4.16667, 33.814, 67.628, 202.884, 0.001, 1000},
                new double[]{1, 0.001, 100, 1000, 1000000, 1000000000, 0.000621371, 1.09361, 3.28084, 39.3701},
                new double[]{1, 0.001, 0.000001, 0.000000001, 1000, 1000000, 0.000000001, 0.000001, 0.008, 8},
                new double[]{1, 60, 0.0166667, 0.000694444, 0.000099206, 0.000022831, 0.0000019026, 0.00000019026, 0.00000001903, 60000},
                };

                respuesta = monedas[cboTipoConversor.SelectedIndex][a] / monedas[cboTipoConversor.SelectedIndex][de] * cantidad;
                lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 3);

            }
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboDeConversores.Items.Clear();
                cboDeConversores.Items.AddRange(TipoDeConversores[cboTipoConversor.SelectedIndex]);

                cboAConversores.Items.Clear();
                cboAConversores.Items.AddRange(TipoDeConversores[cboTipoConversor.SelectedIndex]);
            }
        }
    }
}

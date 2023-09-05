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
        Conversores objConversores = new Conversores();

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

               

                respuesta = objConversores.monedas[cboTipoConversor.SelectedIndex][a] / objConversores.monedas[cboTipoConversor.SelectedIndex][de] * cantidad;
                lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 3);

            }
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboDeConversores.Items.Clear();
                cboDeConversores.Items.AddRange(objConversores.TipoDeConversores[cboTipoConversor.SelectedIndex]);

                cboAConversores.Items.Clear();
                cboAConversores.Items.AddRange(objConversores.TipoDeConversores[cboTipoConversor.SelectedIndex]);
            }
        }
    }
}

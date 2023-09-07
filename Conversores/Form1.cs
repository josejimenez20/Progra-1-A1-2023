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
                int de = 0, a = 0;
                double cantidad = 0, respuesta = 0;
                de = cboDeConversores.SelectedIndex;
                a = cboAConversores.SelectedIndex;
                cantidad = double.Parse(txtCantidadConversores.Text);

                respuesta = objConversores.Convertir(cboTipoConversor.SelectedIndex, de, a, cantidad);
                if (respuesta < 1)
                    lblRespuestaConversores.Text = "Respuesta: "  + respuesta;
                else
                    lblRespuestaConversores.Text = "Respuesta: "  + Math.Round(respuesta, 2);

            }
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboDeConversores.Items.Clear();
                cboDeConversores.Items.AddRange(objConversores.etiquetas[cboTipoConversor.SelectedIndex]);

                cboAConversores.Items.Clear();
                cboAConversores.Items.AddRange(objConversores.etiquetas[cboTipoConversor.SelectedIndex]);
            }
        }
    }
}

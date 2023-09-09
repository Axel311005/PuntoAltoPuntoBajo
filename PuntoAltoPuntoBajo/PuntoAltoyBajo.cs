using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoAltoPuntoBajo
{
    public partial class PuntoAltoyBajo : Form
    {



        Principal principal = new();
        public PuntoAltoyBajo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {



            double[] c = { double.Parse(txtCostosTotales.Text) };
            double[] u = { double.Parse(txtUnidades.Text) };
            principal.costos = c;
            principal.unidades = u;

            Agregar();

        }

        private void Agregar()
        {
            if (Validar() == "")
            {
                ListViewItem fila = new ListViewItem(txtCostosTotales.Text);
                fila.SubItems.Add(txtUnidades.Text);
                lvDatos.Items.Add(fila);


                txtCostosTotales.Clear();
                txtUnidades.Clear();
            }
            else
            {
                MessageBox.Show($"El error esta en {Validar()}");
            }
        }

        private string Validar()
        {

            if (txtCostosTotales.Text.Trim().Length == 0)
            {
                return "los costos totales";
            }
            else if (txtUnidades.Text.Trim().Length == 0)
            {
                return "las horas/unidades producidas";
            }
            else if (double.Parse(txtUnidades.Text) < 0)
            {
                return "las horas/unidades producidas no pueden ser menores que cero";
            }
            else if (double.Parse(txtCostosTotales.Text) < 0)
            {
                return "los costos totales  no pueden ser menores que cero";
            }
            return "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            double CostoAlto;
            double CostoBajo;
            double UnidadAlta;
            double UnidadBaja;

            CostoAlto = principal.MayorCosto();
            CostoBajo = principal.MenorCosto();
            UnidadAlta=principal.MayorUnidad();
            UnidadBaja=principal.MenorUnidad();

            double ct;
            double cvt;
            double cft;
            double cvu;

            cvu=(CostoAlto-CostoAlto)/(UnidadAlta-UnidadBaja);
            ct = CostoAlto;
            cvt = UnidadAlta * cvu;
            cft = ct - cvt;

            txtCostoTotal.Text=ct.ToString();
            txtCostosVariables.Text=cvt.ToString();
            txtCostosFijos.Text=cft.ToString();

            
        }
    }
}

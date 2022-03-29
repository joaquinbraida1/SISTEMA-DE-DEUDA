using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SISTEMA_DE_DEUDA
{
    public partial class fmcarga : Form
    {
        public fmcarga()
        {
            InitializeComponent();
        }

        List<cliente> oListcliente = new List<cliente>();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            cliente ocliente = new cliente();
            ocliente.Apellido = txtapellido.Text;
            ocliente.Nombre = txtnombre.Text;
            ocliente.Fechavencimiento = Convert.ToDateTime(dtpvencimiento.Text);
            ocliente.Fechadepago = Convert.ToDateTime(dtpfechapago.Text);
            ocliente.Deudabruta = double.Parse(txtdeuda.Text);
            ocliente.Descuento = double.Parse(txtdescuento.Text);
            ocliente.Recargo = 0;
            ocliente.DeudaTotal = 0;


            if (ocliente.Apellido == "" || ocliente.Nombre == "" || ocliente.Deudabruta <= 0 ||
                           ocliente.Descuento > 0)
            {
                MessageBox.Show("Verifique que los datos ingresados no se encuentren en blanco y el Descuento en Positivo");
            }
            else
            {
                oListcliente.Add(ocliente);
            }


            double diasrecargo = 0;
            double recargototal = 0;
            double deudatotal = 0;


            foreach (cliente item in oListcliente)
            {

                    diasrecargo = item.Fechadepago.Day - item.Fechavencimiento.Day;

                if (diasrecargo > 0)
                {
                    recargototal = (item.Deudabruta * diasrecargo * 0.01);

                    deudatotal = recargototal + item.Deudabruta + item.Descuento;

                    item.DeudaTotal = deudatotal;
                    item.Recargo = recargototal;

                }
                else
                {
                    recargototal = (item.Deudabruta * diasrecargo * 0*-1);
                    deudatotal = recargototal + item.Deudabruta + item.Descuento;
                    item.DeudaTotal = deudatotal;
                    item.Recargo = recargototal;

                }
                

                lbltotal.Text = deudatotal.ToString();
                lblrecargo.Text = recargototal.ToString();



                dgvdeuda.DataSource = null;
                dgvdeuda.DataSource = oListcliente;

            }
            Limpiar();
        }
    
    private void Limpiar()
    {
        txtapellido.Clear();
        txtnombre.Clear();
        txtdescuento.Clear();
        txtdeuda.Clear();

        txtapellido.Focus();
    }

}
}



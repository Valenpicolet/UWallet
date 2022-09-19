using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto.Interfaces.Interfaces_Clientes
{
    
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirForm(object form)
        {
            PnlPpal.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.PnlPpal.Controls.Add(frm);
            this.PnlPpal.Tag = form;
            frm.Show();
        }
        private void BtnCotizaciones_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmCotizaciones());
        }

        private void BtnTransacciones_Click(object sender, EventArgs e)
        {
            //AbrirForm(new FrmTransacciones());
        }

        private void BtnMonedero_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmMonederos());
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            //AbrirForm(new Frm());
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PnlPpal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

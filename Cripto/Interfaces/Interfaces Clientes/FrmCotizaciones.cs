using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Cripto.Interfaces.Interfaces_Clientes;

namespace Cripto
{
    public partial class FrmCotizaciones : Form
    {

        public FrmCotizaciones()
        {

            InitializeComponent();
        }

        private void FrmCotizaciones_Load(object sender, EventArgs e)
        { 
            SdwFrmCotizacion.SetShadowForm(this);

            DgvCotizaciones.Rows.Add(3);
            DgvCotizaciones.Rows[0].Cells[0].Value = Image.FromFile(@"C:\Users\Usuario\Documents\Mis Documentos Viejo\Valentina\facu\PAV1\Cripto\Cripto\Recursos\ethereum_icon.png");
            DgvCotizaciones.Rows[0].Cells[1].Value = "Ethereum";
            DgvCotizaciones.Rows[1].Cells[0].Value = Image.FromFile(@"C:\Users\Usuario\Documents\Mis Documentos Viejo\Valentina\facu\PAV1\Cripto\Cripto\Recursos\ethereum_icon.png");
  
        }


        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void FrmCotizaciones_Load_1(object sender, EventArgs e)
        {

        }
    }
}

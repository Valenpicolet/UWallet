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
    public partial class FrmMonederos : Form
    {
        public FrmMonederos()
        {
            InitializeComponent();
        }

        private void FrmMonederos_Load(object sender, EventArgs e)
        {
            SdwFrmMonederos.SetShadowForm(this);
        }

        #region Generar Botones Monederos Dinamicamente
        private void GenerarBotonesDinamicos()
        {
            FlpanelMonederos.Controls.Clear();
            BtnMonedero[] listaMonedederos = new BtnMonedero[2]; 
        }
        #endregion

    }
}

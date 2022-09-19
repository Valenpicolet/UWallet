using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto
{
    public partial class BtnMonedero : UserControl
    {
        # region Get & Set para Labels y Picture Box.
        private Image _icon;
        private string _nombre;
        private string _abreviatura;
        private string _cantidadUsd;
        public string ItemNombre
        {
            get { return _nombre; }
            set { _nombre = value; LblNombre.Text = value; }
        }
        public string ItemAbreviatura
        {
            get { return _abreviatura; }
            set {_abreviatura = value; LblAbreviatura.Text = value; }
        }        
        public string ItemCantidad
        {
            get { return _cantidadUsd; }
            set {_cantidadUsd = value; LblCantidadUsd.Text = value; }
        }
        public Image Icono 
        {
            get { return _icon; }
            set { _icon = value; PbIcono.Image = value; }
        }
        # endregion

        public BtnMonedero()
        {
            InitializeComponent();
        }

        private void LblNombre_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            
        }


        private void PnlMonedero_Paint(object sender, PaintEventArgs e)
        {
            this.PnlMonedero.FillColor = Color.FromArgb(225, 255, 255);
            this.PnlMonedero.FillColor2 = Color.FromArgb(0, 125, 255);


        }
    }
}

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
        private Color _color1;
        private Color _color2;
 


        [Category("Custom Props")]
        public string ItemNombre
        {
            get { return _nombre; }
            set { _nombre = value; LblNombre.Text = value; }
        }
        [Category("Custom Props")]
        public string ItemAbreviatura
        {
            get { return _abreviatura; }
            set {_abreviatura = value; LblAbreviatura.Text = value; }
        }
        [Category("Custom Props")]
        public string ItemCantidad
        {
            get { return _cantidadUsd; }
            set {_cantidadUsd = value; LblCantidadUsd.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icono 
        {
            get { return _icon; }
            set { _icon = value; PbIcono.Image = value; }
        }

        [Category("Custom Props")]
        public Color Color1
        {
            get { return _color1; }
            set { _color1 = value; PnlMonedero.FillColor = value; }
        }
        [Category("Custom Props")]
        public Color Color2
        {
            get { return _color2; }
            set { _color2 = value; PnlMonedero.FillColor2 = value; }
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
    }
}

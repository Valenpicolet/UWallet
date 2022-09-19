using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cripto.Repositorio;

namespace Cripto.Interfaces.Interfaces_Clientes
{
    public partial class FrmMonederos : Form
    {
        private readonly MonederoRepositorio monederoRepositorio;
        public FrmMonederos()
        {
            monederoRepositorio = new MonederoRepositorio();
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
            var monederos = monederoRepositorio.GetMonederos();
            BtnMonedero[] listaMonederos = new BtnMonedero[monederos.Count];
            for ( int i = 0; i < 1; i ++  )
            {
                foreach (var celda in monederos)
                {
                    listaMonederos[i].ItemNombre = celda.getIdCripto().getNombre();
                    listaMonederos[i].ItemAbreviatura = celda.getIdCripto().getAbreviacion();
                    listaMonederos[i].ItemCantidad = celda.getSaldo().ToString();
                    if (listaMonederos[i].ItemAbreviatura == "BTN")
                    {
                        listaMonederos[i].Icono = Image.FromFile(@"C:\Users\Usuario\Documents\Mis Documentos Viejo\Valentina\facu\PAV1\Cripto\Cripto\Recursos\ethereum_icon.png");
                        listaMonederos[i].Color1 = Color.FromArgb(125, 255, 255);
                        listaMonederos[i].Color2 = Color.FromArgb(99, 115, 1145);
                    }
                    

                }
                    
            }
            
            

        }
        #endregion

    }
}

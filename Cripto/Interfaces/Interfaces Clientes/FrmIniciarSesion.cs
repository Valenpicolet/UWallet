using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var registraruUsuario = new FrmRegistrarUsuario();
            this.Close();
        }

        private void btnRecuperarContrasenia_Click(object sender, EventArgs e)
        {
            var RecuperarContrasenia = new FrmRecuperarContrasenia();
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraseniaIngresada = txtContrasenia.Text;
            LimpiarCampos();

            // si tenemos el nom de usuario en la BD, ir al principal usuario o admin
            // si no tenemos los datos del usuario en la BD, ir a registrar cliente

            //if (usuarioExiste)
            //{
            //    if usuarioIsCli
            //    {
            //        if tengoDatosUsuario
            //        {    
            //            var principalCliente = new FrmPrincipal();
            //        }
            //        else
            //        {
            //            var registrarCliente = new FrmRegistrarCliente();
            //        }
            //        this.Close();
            //    }
            //    else
            //    {
            //         var principalAdmin = new PrincipalAdmin();
            //    }
            //}
            //else
            //{
            //    lblErrorInicioSesion.Text = "No se pudo iniciar sesión.";
            //    lblErrorInicioSesion.Visible = true;
            //}

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblErrorInicioSesion.Visible = false;
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            lblErrorInicioSesion.Visible = false;
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto.Interfaces.Interfaces_Clientes
{
    public partial class FrmRecuperarContrasenia : Form
    {
        public FrmRecuperarContrasenia()
        {
            InitializeComponent();
        }

        public static bool EsEmailValido(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            string input = txtMail.Text.Trim();
            bool validEmail = EsEmailValido(input);
            if (validEmail == false)
            {
                lblErrorMail.Text = "E-mail no válido.";
                lblErrorMail.Visible = true;
            }
            else
            {
                lblErrorMail.Visible = false;
            }
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            // enviar mail con contraseña

            var iniciarSesion = new FrmIniciarSesion();
            this.Close();
        }
    }
}

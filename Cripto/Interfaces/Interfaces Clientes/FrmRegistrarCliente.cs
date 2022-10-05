using Cripto.Interfaces.Interfaces_Clientes;
using Cripto.Servicios;
using Guna.UI2.WinForms;
using Pav.Entidades;
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
    public partial class FrmRegistrarCliente : Form
    {
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        public bool esDatoValido(string dato)
        {
            if (dato.Equals(""))
                return false;
            else
                return true;

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string ciudad = cmbCiudad.GetItemText(cmbCiudad.SelectedItem);
            string pais = cmbPais.GetItemText(cmbPais.SelectedItem);

            bool tieneNombre = esDatoValido(nombre);
            bool tieneApellido = esDatoValido(apellido);
            bool tieneTelefono = esDatoValido(telefono);
            bool tieneCiudad = esDatoValido(ciudad);
            bool tienePais = esDatoValido(pais);

            bool existeEnLaBD = ExisteEnLaBD(nombre, apellido, telefono, ciudad, pais);

            if (tieneNombre && tieneApellido && tieneTelefono && tieneCiudad && tienePais)
            {
                lblErrorRegistrarCliente.Visible = false;

                if (existeEnLaBD)
                {
                    MostrarError(lblErrorRegistrarCliente, "El cliente ya está registrado.", true);
                    LimpiarCampos();
                }
                else
                {
                    //AltaCliente();
                    var principalCliente = new FrmPrincipal();
                    principalCliente.Show();
                    this.Close();
                }
            }
            else
            {
                MostrarError(lblErrorRegistrarCliente, "Completa todos los datos para registrarte.", true);
            }
        }

        private void AltaCliente(string nombre, string apellido, string telefono, string ciudad) 
        { 
            var sql = $"INSERT INTO Clientes (nombre, apellido, telefono, ciudad)" +
                $"VALUES ('{nombre}', '{apellido}', '{telefono}', '{ciudad}')";
            var res = DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        private bool ExisteEnLaBD(string nombre, string apellido, string telefono, string ciudad, string pais)
        {
            // consultar si el cliente ya existe en la bd
            // si ya existe, deberia sugerir recuperar contraseño (si me acuerdo mañana lo hago)
            throw new NotImplementedException();
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            CargarComboBox(cmbCiudad, "Ciudades");
            CargarComboBox(cmbPais, "Paises");
        }

        private void CargarComboBox(Guna2ComboBox combo, string nomTabla)
        {
            var sql = $"SELECT nombre FROM {nomTabla}";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in res.Rows) 
            { 
                combo.Items.Add(fila["nombre"]); 
            }
        }

        private void FiltrarComboBoxCiudad(Guna2ComboBox combo) 
        {
            var sql = $"SELECT c.nombre FROM Paises p JOIN Ciudades c ON c.cod_pais = p.id_pais";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in res.Rows)
            {
                combo.Items.Add(fila["nombre"]);
            }
        }

        private void MostrarError(Guna2HtmlLabel lbl, string mensaje, bool mostrar)
        {
            lbl.Visible = mostrar;
            lbl.Text = mensaje;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            cmbCiudad.SelectedIndex = -1;
            cmbPais.SelectedIndex = -1;
        }

        private void cmbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltrarComboBoxCiudad(cmbCiudad);
        }
    }
}

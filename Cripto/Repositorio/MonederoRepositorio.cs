using Cripto.Servicios;
using Pav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto.Repositorio
{
    public class MonederoRepositorio
    {
        #region Guardar Monederos
        //public bool GuardarMonederos(Image img, string nombre, string abreviatura, string cantidadUSD, Color color1, Color color2)
        //{
        //    var monederos = new List<Monedero>();
        //    var sql = $"SELECT m.* FROM Monederos m";
        //    var tablaResultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
        //}

        #endregion
        
        
        public List<Monedero> GetMonederos()
        {
            var monederos = new List<Monedero>();
            // Falta el Where para saber q es del usuario logueado
            var sql = $"SELECT u.nombre, m.saldo, c.* FROM Monederos m JOIN Criptomonedas c On m.id_cripto = c.id_cripto JOIN Usuarios u On u.id_usuario = m.id_usuario";
            var tablaResultados = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaResultados.Rows)
            {
                var nombre = fila["nombre"].ToString();
                var nombreCripto = fila["nombre_cripto"].ToString();
                var abrev = fila["abreviacion_cripto"].ToString();
                var saldo = Convert.ToInt32(fila["saldo"]);
                // por si agrego imagen
                //MemoryStream ms = new MemoryStream((byte[])fila["logo"]);
                //var logo = new Bitmap(ms);
                Usuario usuario = new Usuario(nombre);
                Criptomoneda cripto = new Criptomoneda(nombreCripto, abrev);
                var _monedero = new Monedero(usuario, cripto, saldo);

                monederos.Add(_monedero);
            }
            return monederos;
        }
    }
}

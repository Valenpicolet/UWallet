namespace Pav.Entidades
{
    public class Criptomoneda   
   {
        #region Atributos
        private string nombre;
        private string abreviacion;
        private int cantidad;
        #endregion

        #region Accesores
        public string getNombre() { return nombre; }
        public string getAbreviacion() { return abreviacion; }
        public int getCantidad() { return cantidad; }
        public void setNombre(string nombre) { this.nombre = nombre; } 
        public void setAbreviacion(string abreviacion) { this.abreviacion = abreviacion; }
        public void setCantidad(int cantidad) { this.cantidad = cantidad; }
        #endregion

        public Criptomoneda(string nombre,string abreviacion) // int cantidad
        { 
            this.nombre = nombre;
            this.abreviacion = abreviacion;
           // this.cantidad = cantidad;
        }

    }
}

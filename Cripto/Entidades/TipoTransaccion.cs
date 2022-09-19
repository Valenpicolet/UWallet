namespace Pav.Entidades
{
    public class TipoTransaccion
    {
        #region Atributos
        private string descripcion;
        private int comision;
        private int monto_max;
        private int monto_min;
        #endregion

        #region Accesores
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public string getDescripcion() {return this.descripcion;}
        public void setComision(int comision) {this.comision = comision;}
        public int getComision() {return this.comision;}
        public void setMontoMax(int monto_max) {this.monto_max = monto_max;}
        public int getMontoMax() {return this.monto_max;}
        public void setMontoMin(int monto_min) { this.monto_min = monto_min; }
        public int getMontoMin() {return this.monto_min;}
        #endregion

    }
}

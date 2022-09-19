namespace Pav.Entidades
{
    public class Cotizacion
    {
        #region Atributos
        private DateTime fecha_cotizacion;
        private int hora_cotizacion;
        private Criptomoneda criptomoneda;
        private int precio;
        #endregion

        #region Accesores
        public void setFechaCotizacion(DateTime fecha_cotizacion) 
        { 
            this.fecha_cotizacion = fecha_cotizacion.Date;
            this.hora_cotizacion = fecha_cotizacion.Hour;
        }
        public DateTime getFechaCotizacion() { return this.fecha_cotizacion; }
        public void setIdCripto(Criptomoneda criptomoneda) { this.criptomoneda = criptomoneda; }
        public Criptomoneda getIdCripto() { return this.criptomoneda; }
        public void setPrecio(int precio) { this.precio = precio; }
        public int getPrecio() { return this.precio; }
        public int getHoraCotizacion() { return this.hora_cotizacion; }
        #endregion

        public Cotizacion(DateTime fecha,Criptomoneda cripto,int precio) 
        { 
            this.fecha_cotizacion = fecha.Date;
            this.hora_cotizacion= fecha.Hour;
            this.criptomoneda=cripto ;
            this.precio = precio;
        }
    }
}

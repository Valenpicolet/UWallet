using System;

namespace Pav.Entidades
{
    public class Transaccion
    {
        #region Atributos
        private Usuario usuario;
        private DateTime fecha_transaccion;
        private DateTime hora_transaccion;
        private TipoTransaccion tipo;
        private int monto;
        private Criptomoneda cripto;
        #endregion

        #region Accesores
        public void setUsuario(Usuario usuario) { this.usuario = usuario; }
        public Usuario getIdUsuario() { return this.usuario; }
        public void setFechaTransaccion(DateTime fecha_transaccion) { this.fecha_transaccion = fecha_transaccion; }
        public DateTime getFechaTransaccion() { return fecha_transaccion; }
        public void setHoraTransaccion(DateTime hora_transaccion) { this.hora_transaccion = hora_transaccion; }
        public DateTime getHoraTransaccion() { return hora_transaccion; }
        public void setTipo(TipoTransaccion tipo) { this.tipo = tipo; }
        public TipoTransaccion getIdTipo() { return this.tipo; }
        public void setCripto(Criptomoneda cripto) { this.cripto = cripto; }
        public Criptomoneda getIdCripto() { return this.cripto; }
        public void setMonto(int monto) { this.monto = monto; }
        public int getMonto() { return this.monto; }
        #endregion

        public Transaccion() {; }
    }
}

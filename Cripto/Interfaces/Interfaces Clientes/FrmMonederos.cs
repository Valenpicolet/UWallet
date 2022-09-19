using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cripto.Servicios;

namespace Cripto.Interfaces.Interfaces_Clientes
{
    public partial class FrmMonederos : Form
    {
        private readonly MonederosServicio monederosServicio;
        public FrmMonederos()
        {
            monederosServicio = new MonederosServicio();
            InitializeComponent();
        }
        private void FrmMonederos_Load(object sender, EventArgs e)
        {
            PnlMonederos.Controls.Clear();
            CargarMonederos(PnlMonederos);
        }

        private void CargarMonederos(FlowLayoutPanel panel)
        {
            // monederos = Lista con objetos monederos. 0 id, 1 usu, 2 saldo
            var monederos = monederosServicio.GetMonederos();
            foreach (var mon in monederos)
            {
                BtnMonedero btn = new BtnMonedero();
                btn.ItemNombre = mon.Id_cripto.ToString();
                btn.ItemAbreviatura = "ETH";
                btn.ItemCantidad = "$" + mon.Saldo.ToString();
                if (mon.Id_cripto.ToString() != String.Empty)
                {
                    panel.Controls.Add(btn);
                }
            }
            
        }

        private void InitializeComponent()
        {
            this.PnlMonederos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMonedero1 = new Cripto.BtnMonedero();
            this.btnMonedero2 = new Cripto.BtnMonedero();
            this.btnMonedero3 = new Cripto.BtnMonedero();
            this.Pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.LblMisMonederos = new System.Windows.Forms.Label();
            this.PnlMonederos.SuspendLayout();
            this.Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMonederos
            // 
            this.PnlMonederos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlMonederos.BackColor = System.Drawing.Color.White;
            this.PnlMonederos.Controls.Add(this.btnMonedero1);
            this.PnlMonederos.Controls.Add(this.btnMonedero2);
            this.PnlMonederos.Controls.Add(this.btnMonedero3);
            this.PnlMonederos.Location = new System.Drawing.Point(138, 165);
            this.PnlMonederos.Name = "PnlMonederos";
            this.PnlMonederos.Size = new System.Drawing.Size(786, 526);
            this.PnlMonederos.TabIndex = 0;
            // 
            // btnMonedero1
            // 
            this.btnMonedero1.ForeColor = System.Drawing.Color.White;
            this.btnMonedero1.ItemAbreviatura = "Cant + Abrev";
            this.btnMonedero1.ItemCantidad = "Cantidad USD";
            this.btnMonedero1.ItemNombre = "Nombre Cripto";
            this.btnMonedero1.Location = new System.Drawing.Point(3, 3);
            this.btnMonedero1.MonederoID = null;
            this.btnMonedero1.Name = "btnMonedero1";
            this.btnMonedero1.Size = new System.Drawing.Size(250, 150);
            this.btnMonedero1.TabIndex = 1;
            // 
            // btnMonedero2
            // 
            this.btnMonedero2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMonedero2.ForeColor = System.Drawing.Color.White;
            this.btnMonedero2.ItemAbreviatura = "Cant + Abrev";
            this.btnMonedero2.ItemCantidad = "Cantidad USD";
            this.btnMonedero2.ItemNombre = "Nombre Cripto";
            this.btnMonedero2.Location = new System.Drawing.Point(259, 3);
            this.btnMonedero2.MonederoID = null;
            this.btnMonedero2.Name = "btnMonedero2";
            this.btnMonedero2.Size = new System.Drawing.Size(250, 150);
            this.btnMonedero2.TabIndex = 2;
            // 
            // btnMonedero3
            // 
            this.btnMonedero3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMonedero3.ForeColor = System.Drawing.Color.White;
            this.btnMonedero3.ItemAbreviatura = "Cant + Abrev";
            this.btnMonedero3.ItemCantidad = "Cantidad USD";
            this.btnMonedero3.ItemNombre = "Nombre Cripto";
            this.btnMonedero3.Location = new System.Drawing.Point(515, 3);
            this.btnMonedero3.MonederoID = null;
            this.btnMonedero3.Name = "btnMonedero3";
            this.btnMonedero3.Size = new System.Drawing.Size(250, 150);
            this.btnMonedero3.TabIndex = 3;
            // 
            // Pnl
            // 
            this.Pnl.BackColor = System.Drawing.Color.White;
            this.Pnl.Controls.Add(this.LblMisMonederos);
            this.Pnl.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Pnl.CustomBorderThickness = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.Pnl.Location = new System.Drawing.Point(333, 12);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(372, 124);
            this.Pnl.TabIndex = 1;
            // 
            // LblMisMonederos
            // 
            this.LblMisMonederos.AutoSize = true;
            this.LblMisMonederos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMisMonederos.Location = new System.Drawing.Point(131, 15);
            this.LblMisMonederos.Name = "LblMisMonederos";
            this.LblMisMonederos.Size = new System.Drawing.Size(125, 21);
            this.LblMisMonederos.TabIndex = 0;
            this.LblMisMonederos.Text = "Mis Monederos";
            // 
            // FrmMonederos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 703);
            this.Controls.Add(this.Pnl);
            this.Controls.Add(this.PnlMonederos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonederos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMonederos";
            this.PnlMonederos.ResumeLayout(false);
            this.Pnl.ResumeLayout(false);
            this.Pnl.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

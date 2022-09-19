namespace Cripto.Interfaces.Interfaces_Clientes
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEstadisticas = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMonedero = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTransacciones = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCotizaciones = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.BtnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.PnlPpal = new System.Windows.Forms.Panel();
            this.LblBienvenida = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.PnlMenu.SuspendLayout();
            this.PnlPpal.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "U Wallet";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox2.Location = new System.Drawing.Point(0, 118);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 50);
            this.guna2TextBox2.TabIndex = 0;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(15, 22);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(167, 107);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.White;
            this.PnlMenu.Controls.Add(this.BtnCerrarSesion);
            this.PnlMenu.Controls.Add(this.guna2TextBox2);
            this.PnlMenu.Controls.Add(this.guna2CirclePictureBox1);
            this.PnlMenu.Controls.Add(this.BtnEstadisticas);
            this.PnlMenu.Controls.Add(this.BtnMonedero);
            this.PnlMenu.Controls.Add(this.BtnTransacciones);
            this.PnlMenu.Controls.Add(this.BtnCotizaciones);
            this.PnlMenu.Controls.Add(this.guna2Separator1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 703);
            this.PnlMenu.TabIndex = 2;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCerrarSesion.FillColor = System.Drawing.Color.Transparent;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnCerrarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnCerrarSesion.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarSesion.Image")));
            this.BtnCerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCerrarSesion.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnCerrarSesion.Location = new System.Drawing.Point(10, 627);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(180, 45);
            this.BtnCerrarSesion.TabIndex = 5;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEstadisticas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEstadisticas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEstadisticas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEstadisticas.FillColor = System.Drawing.Color.Transparent;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnEstadisticas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnEstadisticas.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEstadisticas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BtnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstadisticas.Image")));
            this.BtnEstadisticas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEstadisticas.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnEstadisticas.Location = new System.Drawing.Point(10, 527);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(180, 45);
            this.BtnEstadisticas.TabIndex = 1;
            this.BtnEstadisticas.Text = "Estadísticas";
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // BtnMonedero
            // 
            this.BtnMonedero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMonedero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMonedero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMonedero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMonedero.FillColor = System.Drawing.Color.Transparent;
            this.BtnMonedero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnMonedero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnMonedero.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnMonedero.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnMonedero.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BtnMonedero.Image = ((System.Drawing.Image)(resources.GetObject("BtnMonedero.Image")));
            this.BtnMonedero.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMonedero.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnMonedero.Location = new System.Drawing.Point(10, 427);
            this.BtnMonedero.Name = "BtnMonedero";
            this.BtnMonedero.Size = new System.Drawing.Size(180, 45);
            this.BtnMonedero.TabIndex = 1;
            this.BtnMonedero.Text = "Monedero";
            this.BtnMonedero.Click += new System.EventHandler(this.BtnMonedero_Click);
            // 
            // BtnTransacciones
            // 
            this.BtnTransacciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransacciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransacciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTransacciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTransacciones.FillColor = System.Drawing.Color.Transparent;
            this.BtnTransacciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnTransacciones.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnTransacciones.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnTransacciones.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.BtnTransacciones.Image = ((System.Drawing.Image)(resources.GetObject("BtnTransacciones.Image")));
            this.BtnTransacciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTransacciones.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnTransacciones.Location = new System.Drawing.Point(10, 327);
            this.BtnTransacciones.Name = "BtnTransacciones";
            this.BtnTransacciones.Size = new System.Drawing.Size(180, 45);
            this.BtnTransacciones.TabIndex = 1;
            this.BtnTransacciones.Text = "Transacciones";
            this.BtnTransacciones.Click += new System.EventHandler(this.BtnTransacciones_Click);
            // 
            // BtnCotizaciones
            // 
            this.BtnCotizaciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCotizaciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCotizaciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCotizaciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCotizaciones.FillColor = System.Drawing.Color.Transparent;
            this.BtnCotizaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCotizaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnCotizaciones.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnCotizaciones.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.BtnCotizaciones.Image = ((System.Drawing.Image)(resources.GetObject("BtnCotizaciones.Image")));
            this.BtnCotizaciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCotizaciones.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnCotizaciones.Location = new System.Drawing.Point(10, 227);
            this.BtnCotizaciones.Name = "BtnCotizaciones";
            this.BtnCotizaciones.Size = new System.Drawing.Size(180, 45);
            this.BtnCotizaciones.TabIndex = 1;
            this.BtnCotizaciones.Text = "Cotizaciones";
            this.BtnCotizaciones.Click += new System.EventHandler(this.BtnCotizaciones_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 165);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(205, 12);
            this.guna2Separator1.TabIndex = 1;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMinimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizar.HoverState.FillColor = System.Drawing.Color.LightSteelBlue;
            this.BtnMinimizar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(898, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(39, 30);
            this.BtnMinimizar.TabIndex = 3;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.HoverState.FillColor = System.Drawing.Color.Red;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(943, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(39, 30);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlPpal
            // 
            this.PnlPpal.Controls.Add(this.LblInfo);
            this.PnlPpal.Controls.Add(this.LblBienvenida);
            this.PnlPpal.Location = new System.Drawing.Point(196, 0);
            this.PnlPpal.Name = "PnlPpal";
            this.PnlPpal.Size = new System.Drawing.Size(786, 703);
            this.PnlPpal.TabIndex = 5;
            this.PnlPpal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPpal_Paint);
            // 
            // LblBienvenida
            // 
            this.LblBienvenida.AutoSize = true;
            this.LblBienvenida.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenida.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblBienvenida.Location = new System.Drawing.Point(148, 118);
            this.LblBienvenida.Name = "LblBienvenida";
            this.LblBienvenida.Size = new System.Drawing.Size(356, 45);
            this.LblBienvenida.TabIndex = 0;
            this.LblBienvenida.Text = "Bienvenido a U Wallet";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblInfo.Location = new System.Drawing.Point(105, 182);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(574, 21);
            this.LblInfo.TabIndex = 1;
            this.LblInfo.Text = "Comienza tu experiencia con U Wallet precionando alguna opción del menú!";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 703);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.PnlPpal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.PnlMenu.ResumeLayout(false);
            this.PnlPpal.ResumeLayout(false);
            this.PnlPpal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel PnlMenu;
        private Guna.UI2.WinForms.Guna2Button BtnCerrarSesion;
        private Guna.UI2.WinForms.Guna2Button BtnEstadisticas;
        private Guna.UI2.WinForms.Guna2Button BtnMonedero;
        private Guna.UI2.WinForms.Guna2Button BtnTransacciones;
        private Guna.UI2.WinForms.Guna2Button BtnCotizaciones;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button BtnMinimizar;
        private Guna.UI2.WinForms.Guna2Button BtnCerrar;
        private System.Windows.Forms.Panel PnlPpal;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblBienvenida;
    }
}
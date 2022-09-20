namespace PAV
{
    partial class FrmIniciarSesion
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
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.lblIniciarSesion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNoCuenta = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecuperarContrasenia = new Guna.UI2.WinForms.Guna2Button();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblErrorInicioSesion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.cbClose.IconColor = System.Drawing.Color.White;
            this.cbClose.Location = new System.Drawing.Point(309, 0);
            this.cbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(45, 29);
            this.cbClose.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Animated = true;
            this.txtUsuario.AutoRoundedCorners = true;
            this.txtUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtUsuario.BorderRadius = 17;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(48, 214);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(257, 36);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Animated = true;
            this.txtContrasenia.AutoRoundedCorners = true;
            this.txtContrasenia.BorderColor = System.Drawing.Color.Silver;
            this.txtContrasenia.BorderRadius = 17;
            this.txtContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenia.DefaultText = "";
            this.txtContrasenia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasenia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasenia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenia.Location = new System.Drawing.Point(48, 264);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '\0';
            this.txtContrasenia.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtContrasenia.PlaceholderText = " Contraseña";
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.Size = new System.Drawing.Size(257, 36);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Animated = true;
            this.btnIniciarSesion.AutoRoundedCorners = true;
            this.btnIniciarSesion.BorderRadius = 21;
            this.btnIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniciarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnIniciarSesion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.btnIniciarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.btnIniciarSesion.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IndicateFocus = true;
            this.btnIniciarSesion.Location = new System.Drawing.Point(82, 375);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(180, 45);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(105, 158);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(132, 27);
            this.lblIniciarSesion.TabIndex = 80;
            this.lblIniciarSesion.Text = "Iniciar Sesión";
            // 
            // lblNoCuenta
            // 
            this.lblNoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCuenta.Location = new System.Drawing.Point(82, 453);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(133, 17);
            this.lblNoCuenta.TabIndex = 82;
            this.lblNoCuenta.Text = "¿No tienes una cuenta?";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnRegistrar.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.btnRegistrar.IndicateFocus = true;
            this.btnRegistrar.Location = new System.Drawing.Point(204, 452);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 20);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrate";
            this.btnRegistrar.UseTransparentBackground = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnRecuperarContrasenia
            // 
            this.btnRecuperarContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContrasenia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecuperarContrasenia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecuperarContrasenia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecuperarContrasenia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecuperarContrasenia.FillColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContrasenia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.btnRecuperarContrasenia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecuperarContrasenia.ForeColor = System.Drawing.Color.Gray;
            this.btnRecuperarContrasenia.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContrasenia.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContrasenia.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContrasenia.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btnRecuperarContrasenia.IndicateFocus = true;
            this.btnRecuperarContrasenia.Location = new System.Drawing.Point(82, 310);
            this.btnRecuperarContrasenia.Name = "btnRecuperarContrasenia";
            this.btnRecuperarContrasenia.Size = new System.Drawing.Size(190, 20);
            this.btnRecuperarContrasenia.TabIndex = 4;
            this.btnRecuperarContrasenia.Text = "¿Has olvidado tu contraseña?";
            this.btnRecuperarContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecuperarContrasenia.UseTransparentBackground = true;
            this.btnRecuperarContrasenia.Click += new System.EventHandler(this.btnRecuperarContrasenia_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(105, 35);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(132, 107);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // lblErrorInicioSesion
            // 
            this.lblErrorInicioSesion.AutoSize = false;
            this.lblErrorInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorInicioSesion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorInicioSesion.Location = new System.Drawing.Point(48, 336);
            this.lblErrorInicioSesion.Name = "lblErrorInicioSesion";
            this.lblErrorInicioSesion.Size = new System.Drawing.Size(257, 33);
            this.lblErrorInicioSesion.TabIndex = 81;
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 483);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorInicioSesion);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnRecuperarContrasenia);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblNoCuenta);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cbClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIniciarSesion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoCuenta;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2Button btnRecuperarContrasenia;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErrorInicioSesion;
    }
}


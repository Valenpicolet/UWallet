namespace PAV
{
    partial class FrmRegistrarUsuario
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
            this.txtNombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRepetirContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnRegistrarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.lblRegistrarUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblContraseniasNoCoinciden = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblErrorNombreUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblErrorMail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblErrorRegistrarUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Animated = true;
            this.txtNombreUsuario.AutoRoundedCorners = true;
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtNombreUsuario.BorderRadius = 17;
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.DefaultText = "";
            this.txtNombreUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUsuario.Location = new System.Drawing.Point(49, 138);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNombreUsuario.PlaceholderText = "Nombre de usuario";
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(257, 36);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Animated = true;
            this.txtMail.AutoRoundedCorners = true;
            this.txtMail.BorderColor = System.Drawing.Color.Silver;
            this.txtMail.BorderRadius = 17;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Location = new System.Drawing.Point(49, 211);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMail.PlaceholderText = "E-mail";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(257, 36);
            this.txtMail.TabIndex = 2;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
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
            this.txtContrasenia.Location = new System.Drawing.Point(49, 285);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '●';
            this.txtContrasenia.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtContrasenia.PlaceholderText = "Contraseña";
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.Size = new System.Drawing.Size(257, 36);
            this.txtContrasenia.TabIndex = 3;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtRepetirContrasenia
            // 
            this.txtRepetirContrasenia.Animated = true;
            this.txtRepetirContrasenia.AutoRoundedCorners = true;
            this.txtRepetirContrasenia.BorderColor = System.Drawing.Color.Silver;
            this.txtRepetirContrasenia.BorderRadius = 17;
            this.txtRepetirContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepetirContrasenia.DefaultText = "";
            this.txtRepetirContrasenia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRepetirContrasenia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRepetirContrasenia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepetirContrasenia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepetirContrasenia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepetirContrasenia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRepetirContrasenia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepetirContrasenia.Location = new System.Drawing.Point(49, 335);
            this.txtRepetirContrasenia.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRepetirContrasenia.Name = "txtRepetirContrasenia";
            this.txtRepetirContrasenia.PasswordChar = '●';
            this.txtRepetirContrasenia.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRepetirContrasenia.PlaceholderText = "Repetir contraseña";
            this.txtRepetirContrasenia.SelectedText = "";
            this.txtRepetirContrasenia.Size = new System.Drawing.Size(257, 36);
            this.txtRepetirContrasenia.TabIndex = 4;
            this.txtRepetirContrasenia.UseSystemPasswordChar = true;
            this.txtRepetirContrasenia.TextChanged += new System.EventHandler(this.txtRepetirContrasenia_TextChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(309, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Animated = true;
            this.btnRegistrarUsuario.AutoRoundedCorners = true;
            this.btnRegistrarUsuario.BorderRadius = 21;
            this.btnRegistrarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.IndicateFocus = true;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(82, 462);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(180, 45);
            this.btnRegistrarUsuario.TabIndex = 6;
            this.btnRegistrarUsuario.Text = "Registrar usuario";
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // lblRegistrarUsuario
            // 
            this.lblRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarUsuario.Location = new System.Drawing.Point(92, 66);
            this.lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            this.lblRegistrarUsuario.Size = new System.Drawing.Size(170, 27);
            this.lblRegistrarUsuario.TabIndex = 7;
            this.lblRegistrarUsuario.Text = "Registrar Usuario";
            // 
            // lblContraseniasNoCoinciden
            // 
            this.lblContraseniasNoCoinciden.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseniasNoCoinciden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniasNoCoinciden.ForeColor = System.Drawing.Color.Red;
            this.lblContraseniasNoCoinciden.Location = new System.Drawing.Point(49, 381);
            this.lblContraseniasNoCoinciden.Name = "lblContraseniasNoCoinciden";
            this.lblContraseniasNoCoinciden.Size = new System.Drawing.Size(190, 17);
            this.lblContraseniasNoCoinciden.TabIndex = 8;
            this.lblContraseniasNoCoinciden.Text = "INGRESAR ERROR Y VISIBILIZAR";
            this.lblContraseniasNoCoinciden.Visible = false;
            // 
            // lblErrorNombreUsuario
            // 
            this.lblErrorNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombreUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombreUsuario.Location = new System.Drawing.Point(49, 184);
            this.lblErrorNombreUsuario.Name = "lblErrorNombreUsuario";
            this.lblErrorNombreUsuario.Size = new System.Drawing.Size(190, 17);
            this.lblErrorNombreUsuario.TabIndex = 9;
            this.lblErrorNombreUsuario.Text = "INGRESAR ERROR Y VISIBILIZAR";
            this.lblErrorNombreUsuario.Visible = false;
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(49, 257);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(190, 17);
            this.lblErrorMail.TabIndex = 10;
            this.lblErrorMail.Text = "INGRESAR ERROR Y VISIBILIZAR";
            this.lblErrorMail.Visible = false;
            // 
            // lblErrorRegistrarUsuario
            // 
            this.lblErrorRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRegistrarUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRegistrarUsuario.Location = new System.Drawing.Point(49, 418);
            this.lblErrorRegistrarUsuario.Name = "lblErrorRegistrarUsuario";
            this.lblErrorRegistrarUsuario.Size = new System.Drawing.Size(190, 17);
            this.lblErrorRegistrarUsuario.TabIndex = 11;
            this.lblErrorRegistrarUsuario.Text = "INGRESAR ERROR Y VISIBILIZAR";
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 543);
            this.Controls.Add(this.lblErrorRegistrarUsuario);
            this.Controls.Add(this.lblErrorMail);
            this.Controls.Add(this.lblErrorNombreUsuario);
            this.Controls.Add(this.lblContraseniasNoCoinciden);
            this.Controls.Add(this.lblRegistrarUsuario);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.txtRepetirContrasenia);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNombreUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nuevo usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia;
        private Guna.UI2.WinForms.Guna2TextBox txtRepetirContrasenia;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegistrarUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContraseniasNoCoinciden;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErrorNombreUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErrorMail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErrorRegistrarUsuario;
    }
}
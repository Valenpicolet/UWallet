namespace Cripto.Interfaces.Interfaces_Clientes
{
    partial class FrmRecuperarContrasenia
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblRecuperarContrasenia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnviarMail = new Guna.UI2.WinForms.Guna2Button();
            this.lblErrorMail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(309, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // lblRecuperarContrasenia
            // 
            this.lblRecuperarContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperarContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarContrasenia.Location = new System.Drawing.Point(65, 69);
            this.lblRecuperarContrasenia.Name = "lblRecuperarContrasenia";
            this.lblRecuperarContrasenia.Size = new System.Drawing.Size(220, 27);
            this.lblRecuperarContrasenia.TabIndex = 1;
            this.lblRecuperarContrasenia.Text = "Recuperar Contraseña";
            // 
            // txtMail
            // 
            this.txtMail.Animated = true;
            this.txtMail.AutoRoundedCorners = true;
            this.txtMail.BorderColor = System.Drawing.Color.Silver;
            this.txtMail.BorderRadius = 17;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "E-mail";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Location = new System.Drawing.Point(47, 132);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(257, 36);
            this.txtMail.TabIndex = 2;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // btnEnviarMail
            // 
            this.btnEnviarMail.Animated = true;
            this.btnEnviarMail.AutoRoundedCorners = true;
            this.btnEnviarMail.BorderRadius = 21;
            this.btnEnviarMail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviarMail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviarMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnviarMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnviarMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnEnviarMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMail.ForeColor = System.Drawing.Color.White;
            this.btnEnviarMail.IndicateFocus = true;
            this.btnEnviarMail.Location = new System.Drawing.Point(84, 216);
            this.btnEnviarMail.Name = "btnEnviarMail";
            this.btnEnviarMail.Size = new System.Drawing.Size(180, 45);
            this.btnEnviarMail.TabIndex = 3;
            this.btnEnviarMail.Text = "Enviar mail";
            this.btnEnviarMail.Click += new System.EventHandler(this.btnEnviarMail_Click);
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(47, 176);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(190, 17);
            this.lblErrorMail.TabIndex = 4;
            this.lblErrorMail.Text = "INGRESAR ERROR Y VISIBILIZAR";
            // 
            // RecuperarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 303);
            this.Controls.Add(this.lblErrorMail);
            this.Controls.Add(this.btnEnviarMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblRecuperarContrasenia);
            this.Controls.Add(this.guna2ControlBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RecuperarContrasenia";
            this.Text = "RecuperarContrasenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecuperarContrasenia;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2Button btnEnviarMail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErrorMail;
    }
}

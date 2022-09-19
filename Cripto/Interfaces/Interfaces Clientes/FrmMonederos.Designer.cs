namespace Cripto.Interfaces.Interfaces_Clientes
{
    partial class FrmMonederos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonederos));
            this.SdwFrmMonederos = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.DragControlFrmMonederos = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FlpanelMonederos = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // SdwFrmMonederos
            // 
            this.SdwFrmMonederos.TargetForm = this;
            // 
            // DragControlFrmMonederos
            // 
            this.DragControlFrmMonederos.DockIndicatorTransparencyValue = 0.6D;
            this.DragControlFrmMonederos.TargetControl = this;
            this.DragControlFrmMonederos.UseTransparentDrag = true;
            // 
            // FlpanelMonederos
            // 
            this.FlpanelMonederos.AutoScroll = true;
            this.FlpanelMonederos.BackColor = System.Drawing.Color.White;
            this.FlpanelMonederos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpanelMonederos.Location = new System.Drawing.Point(0, 306);
            this.FlpanelMonederos.Name = "FlpanelMonederos";
            this.FlpanelMonederos.Size = new System.Drawing.Size(1000, 436);
            this.FlpanelMonederos.TabIndex = 0;
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
            this.BtnMinimizar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(913, 1);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(39, 30);
            this.BtnMinimizar.TabIndex = 5;
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
            this.BtnCerrar.Location = new System.Drawing.Point(958, 1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(39, 30);
            this.BtnCerrar.TabIndex = 6;
            // 
            // FrmMonederos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 742);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.FlpanelMonederos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonederos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMonederos";
            this.Load += new System.EventHandler(this.FrmMonederos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm SdwFrmMonederos;
        private Guna.UI2.WinForms.Guna2DragControl DragControlFrmMonederos;
        private System.Windows.Forms.FlowLayoutPanel FlpanelMonederos;
        private Guna.UI2.WinForms.Guna2Button BtnMinimizar;
        private Guna.UI2.WinForms.Guna2Button BtnCerrar;
    }
}
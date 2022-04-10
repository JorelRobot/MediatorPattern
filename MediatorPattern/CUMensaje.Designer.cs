namespace MediatorPattern
{
    partial class CUMensaje
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBodyMessagge = new System.Windows.Forms.Label();
            this.lblDateMessagge = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBodyMessagge
            // 
            this.lblBodyMessagge.AutoSize = true;
            this.lblBodyMessagge.Location = new System.Drawing.Point(223, 8);
            this.lblBodyMessagge.Name = "lblBodyMessagge";
            this.lblBodyMessagge.Size = new System.Drawing.Size(76, 20);
            this.lblBodyMessagge.TabIndex = 0;
            this.lblBodyMessagge.Text = "Messagge";
            this.lblBodyMessagge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDateMessagge
            // 
            this.lblDateMessagge.AutoSize = true;
            this.lblDateMessagge.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDateMessagge.ForeColor = System.Drawing.Color.Gray;
            this.lblDateMessagge.Location = new System.Drawing.Point(210, 3);
            this.lblDateMessagge.Name = "lblDateMessagge";
            this.lblDateMessagge.Size = new System.Drawing.Size(92, 17);
            this.lblDateMessagge.TabIndex = 1;
            this.lblDateMessagge.Text = "Messagge Date";
            this.lblDateMessagge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBodyMessagge);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 67);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDateMessagge);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 24);
            this.panel2.TabIndex = 3;
            // 
            // CUMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CUMensaje";
            this.Size = new System.Drawing.Size(310, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblBodyMessagge;
        private Label lblDateMessagge;
        private Panel panel1;
        private Panel panel2;
    }
}

namespace MediatorPattern
{
    partial class UserCardSidebar
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
            this.username = new System.Windows.Forms.Label();
            this.lastmessagge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(14, 10);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(99, 28);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // lastmessagge
            // 
            this.lastmessagge.AutoSize = true;
            this.lastmessagge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lastmessagge.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastmessagge.Location = new System.Drawing.Point(14, 38);
            this.lastmessagge.Name = "lastmessagge";
            this.lastmessagge.Size = new System.Drawing.Size(114, 20);
            this.lastmessagge.TabIndex = 1;
            this.lastmessagge.Text = "Last Messagge ...";
            // 
            // UserCardSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lastmessagge);
            this.Controls.Add(this.username);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserCardSidebar";
            this.Size = new System.Drawing.Size(275, 70);
            this.MouseEnter += new System.EventHandler(this.UserCardSidebar_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserCardSidebar_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username;
        private Label lastmessagge;
    }
}

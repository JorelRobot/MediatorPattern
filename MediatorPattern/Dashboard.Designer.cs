namespace MediatorPattern
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAmigos = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblChatFrindName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panelAmigos);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 718);
            this.panel1.TabIndex = 0;
            // 
            // panelAmigos
            // 
            this.panelAmigos.AutoScroll = true;
            this.panelAmigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAmigos.Location = new System.Drawing.Point(0, 80);
            this.panelAmigos.Name = "panelAmigos";
            this.panelAmigos.Size = new System.Drawing.Size(287, 638);
            this.panelAmigos.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblUserName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 80);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "En linea";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(12, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(205, 26);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Nombre de usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panelWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(287, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 718);
            this.panel2.TabIndex = 0;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.White;
            this.panelWelcome.Controls.Add(this.label2);
            this.panelWelcome.Location = new System.Drawing.Point(6, 12);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(717, 703);
            this.panelWelcome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecciona a un amigo para poder chatear";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(6, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 636);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.Controls.Add(this.lblChatFrindName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(705, 68);
            this.panel4.TabIndex = 0;
            // 
            // lblChatFrindName
            // 
            this.lblChatFrindName.AutoSize = true;
            this.lblChatFrindName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChatFrindName.ForeColor = System.Drawing.Color.White;
            this.lblChatFrindName.Location = new System.Drawing.Point(23, 18);
            this.lblChatFrindName.Name = "lblChatFrindName";
            this.lblChatFrindName.Size = new System.Drawing.Size(251, 35);
            this.lblChatFrindName.TabIndex = 0;
            this.lblChatFrindName.Text = "Nombre de amigo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(579, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 654);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 52);
            this.textBox1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel4;
        private Label lblChatFrindName;
        private Panel panel5;
        private Panel panelAmigos;
        private Label label3;
        private Label lblUserName;
        private Panel panelWelcome;
        private Label label2;
    }
}
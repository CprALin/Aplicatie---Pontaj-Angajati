namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.angajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angajatiToolStripMenuItem,
            this.departamenteToolStripMenuItem,
            this.pontajeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // angajatiToolStripMenuItem
            // 
            this.angajatiToolStripMenuItem.Name = "angajatiToolStripMenuItem";
            this.angajatiToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.angajatiToolStripMenuItem.Text = "Angajati";
            this.angajatiToolStripMenuItem.Click += new System.EventHandler(this.angajatiToolStripMenuItem_Click);
            // 
            // departamenteToolStripMenuItem
            // 
            this.departamenteToolStripMenuItem.Name = "departamenteToolStripMenuItem";
            this.departamenteToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.departamenteToolStripMenuItem.Text = "Departamente";
            this.departamenteToolStripMenuItem.Click += new System.EventHandler(this.departamenteToolStripMenuItem_Click);
            // 
            // pontajeToolStripMenuItem
            // 
            this.pontajeToolStripMenuItem.Name = "pontajeToolStripMenuItem";
            this.pontajeToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.pontajeToolStripMenuItem.Text = "Pontaje";
            this.pontajeToolStripMenuItem.Click += new System.EventHandler(this.pontajeToolStripMenuItem_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(126, 80);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(525, 26);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Aplicatie pt. pontajul angajatilor dintr-o societate";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(272, 117);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(236, 20);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor : Dragomir Alin - Ciprian";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(256, 211);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(58, 16);
            this.lblUtilizator.TabIndex = 3;
            this.lblUtilizator.Text = "Utilizator";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(256, 272);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(47, 16);
            this.lblParola.TabIndex = 4;
            this.lblParola.Text = "Parola";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(332, 208);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(124, 22);
            this.txtUtilizator.TabIndex = 5;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(332, 269);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(124, 22);
            this.txtParola.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(355, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem angajatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontajeToolStripMenuItem;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnStart;
    }
}


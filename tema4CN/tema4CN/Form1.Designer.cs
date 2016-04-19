namespace tema4CN
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gaussSiedel = new System.Windows.Forms.Button();
            this.newton = new System.Windows.Forms.Button();
            this.newtonSimp = new System.Windows.Forms.Button();
            this.lagrangeButton = new System.Windows.Forms.Button();
            this.newtonDiferente = new System.Windows.Forms.Button();
            this.newtonAscendenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Contractiei";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.concractiei_click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(647, 476);
            this.dataGridView1.TabIndex = 1;
            // 
            // gaussSiedel
            // 
            this.gaussSiedel.Location = new System.Drawing.Point(653, 41);
            this.gaussSiedel.Name = "gaussSiedel";
            this.gaussSiedel.Size = new System.Drawing.Size(158, 23);
            this.gaussSiedel.TabIndex = 0;
            this.gaussSiedel.Text = "Gauss Siedel Neliniara";
            this.gaussSiedel.UseVisualStyleBackColor = true;
            this.gaussSiedel.Click += new System.EventHandler(this.gaussSiedel_Click);
            // 
            // newton
            // 
            this.newton.Location = new System.Drawing.Point(653, 101);
            this.newton.Name = "newton";
            this.newton.Size = new System.Drawing.Size(158, 23);
            this.newton.TabIndex = 0;
            this.newton.Text = "Newton";
            this.newton.UseVisualStyleBackColor = true;
            this.newton.Click += new System.EventHandler(this.newton_Click);
            // 
            // newtonSimp
            // 
            this.newtonSimp.Location = new System.Drawing.Point(653, 130);
            this.newtonSimp.Name = "newtonSimp";
            this.newtonSimp.Size = new System.Drawing.Size(158, 23);
            this.newtonSimp.TabIndex = 0;
            this.newtonSimp.Text = "Newton Simplificata";
            this.newtonSimp.UseVisualStyleBackColor = true;
            this.newtonSimp.Click += new System.EventHandler(this.newtonSimp_Click);
            // 
            // lagrangeButton
            // 
            this.lagrangeButton.Location = new System.Drawing.Point(653, 193);
            this.lagrangeButton.Name = "lagrangeButton";
            this.lagrangeButton.Size = new System.Drawing.Size(158, 23);
            this.lagrangeButton.TabIndex = 0;
            this.lagrangeButton.Text = "Lagrange";
            this.lagrangeButton.UseVisualStyleBackColor = true;
            this.lagrangeButton.Click += new System.EventHandler(this.lagrangeButton_Click);
            // 
            // newtonDiferente
            // 
            this.newtonDiferente.Location = new System.Drawing.Point(653, 222);
            this.newtonDiferente.Name = "newtonDiferente";
            this.newtonDiferente.Size = new System.Drawing.Size(158, 23);
            this.newtonDiferente.TabIndex = 0;
            this.newtonDiferente.Text = "NewtonDiferente";
            this.newtonDiferente.UseVisualStyleBackColor = true;
            this.newtonDiferente.Click += new System.EventHandler(this.newtonDiferente_Click);
            // 
            // newtonAscendenta
            // 
            this.newtonAscendenta.Location = new System.Drawing.Point(653, 280);
            this.newtonAscendenta.Name = "newtonAscendenta";
            this.newtonAscendenta.Size = new System.Drawing.Size(158, 23);
            this.newtonAscendenta.TabIndex = 0;
            this.newtonAscendenta.Text = "Newton Ascendenta";
            this.newtonAscendenta.UseVisualStyleBackColor = true;
            this.newtonAscendenta.Click += new System.EventHandler(this.newtonAscendenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newtonAscendenta);
            this.Controls.Add(this.newtonDiferente);
            this.Controls.Add(this.lagrangeButton);
            this.Controls.Add(this.newtonSimp);
            this.Controls.Add(this.newton);
            this.Controls.Add(this.gaussSiedel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tema 4 CN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gaussSiedel;
        private System.Windows.Forms.Button newton;
        private System.Windows.Forms.Button newtonSimp;
        private System.Windows.Forms.Button lagrangeButton;
        private System.Windows.Forms.Button newtonDiferente;
        private System.Windows.Forms.Button newtonAscendenta;
    }
}


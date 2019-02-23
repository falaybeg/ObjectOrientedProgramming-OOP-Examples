namespace OOPClassObject
{
    partial class RegistrationScreen
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
            this.ad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maas = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sicilno = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(98, 95);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(45, 17);
            this.ad.TabIndex = 0;
            this.ad.Text = "Name";
            this.ad.Click += new System.EventHandler(this.ad_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 2;
            // 
            // maas
            // 
            this.maas.AutoSize = true;
            this.maas.Location = new System.Drawing.Point(91, 200);
            this.maas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(52, 17);
            this.maas.TabIndex = 2;
            this.maas.Text = "Salary ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 47);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 22);
            this.textBox3.TabIndex = 1;
            // 
            // sicilno
            // 
            this.sicilno.AutoSize = true;
            this.sicilno.Location = new System.Drawing.Point(79, 47);
            this.sicilno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sicilno.Name = "sicilno";
            this.sicilno.Size = new System.Drawing.Size(75, 17);
            this.sicilno.TabIndex = 4;
            this.sicilno.Text = "Identity No";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 149);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 3;
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(78, 154);
            this.soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(65, 17);
            this.soyad.TabIndex = 6;
            this.soyad.Text = "Surname";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(162, 200);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.sicilno);
            this.Controls.Add(this.maas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationScreen";
            this.Text = "New Employee Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label maas;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label sicilno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}


namespace Inheritance
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
            this.txtOgrenci = new System.Windows.Forms.Button();
            this.txtOgretmen = new System.Windows.Forms.Button();
            this.txtMudur = new System.Windows.Forms.Button();
            this.txtMemur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenci.Location = new System.Drawing.Point(108, 118);
            this.txtOgrenci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(159, 34);
            this.txtOgrenci.TabIndex = 0;
            this.txtOgrenci.Text = "Student Info";
            this.txtOgrenci.UseVisualStyleBackColor = true;
            this.txtOgrenci.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOgretmen
            // 
            this.txtOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgretmen.Location = new System.Drawing.Point(108, 163);
            this.txtOgretmen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgretmen.Name = "txtOgretmen";
            this.txtOgretmen.Size = new System.Drawing.Size(159, 34);
            this.txtOgretmen.TabIndex = 1;
            this.txtOgretmen.Text = "Teacher Info";
            this.txtOgretmen.UseVisualStyleBackColor = true;
            this.txtOgretmen.Click += new System.EventHandler(this.txtOgretmen_Click);
            // 
            // txtMudur
            // 
            this.txtMudur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMudur.Location = new System.Drawing.Point(108, 208);
            this.txtMudur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMudur.Name = "txtMudur";
            this.txtMudur.Size = new System.Drawing.Size(159, 34);
            this.txtMudur.TabIndex = 2;
            this.txtMudur.Text = "Headmaster";
            this.txtMudur.UseVisualStyleBackColor = true;
            this.txtMudur.Click += new System.EventHandler(this.txtMudur_Click);
            // 
            // txtMemur
            // 
            this.txtMemur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemur.Location = new System.Drawing.Point(108, 254);
            this.txtMemur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemur.Name = "txtMemur";
            this.txtMemur.Size = new System.Drawing.Size(159, 34);
            this.txtMemur.TabIndex = 3;
            this.txtMemur.Text = "Employee Info";
            this.txtMemur.UseVisualStyleBackColor = true;
            this.txtMemur.Click += new System.EventHandler(this.txtMemur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inheritance User Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please click which user info you want to see.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemur);
            this.Controls.Add(this.txtMudur);
            this.Controls.Add(this.txtOgretmen);
            this.Controls.Add(this.txtOgrenci);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Inheritance User Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtOgrenci;
        private System.Windows.Forms.Button txtOgretmen;
        private System.Windows.Forms.Button txtMudur;
        private System.Windows.Forms.Button txtMemur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


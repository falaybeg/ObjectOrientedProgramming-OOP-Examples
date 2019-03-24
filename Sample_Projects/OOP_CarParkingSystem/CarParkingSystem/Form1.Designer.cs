namespace CarParkingSystem
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listbox_VehicleType = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox_Subscriber = new System.Windows.Forms.CheckBox();
            this.checkBox_Contact = new System.Windows.Forms.CheckBox();
            this.label_type = new System.Windows.Forms.Label();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.label_plate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_Vehicles = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_dailyreport = new System.Windows.Forms.Button();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.lbl_plate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listbox_VehicleType);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkBox_Subscriber);
            this.groupBox1.Controls.Add(this.checkBox_Contact);
            this.groupBox1.Controls.Add(this.label_type);
            this.groupBox1.Controls.Add(this.txtPlateNo);
            this.groupBox1.Controls.Add(this.label_plate);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance";
            // 
            // listbox_VehicleType
            // 
            this.listbox_VehicleType.FormattingEnabled = true;
            this.listbox_VehicleType.Location = new System.Drawing.Point(106, 81);
            this.listbox_VehicleType.Name = "listbox_VehicleType";
            this.listbox_VehicleType.Size = new System.Drawing.Size(166, 69);
            this.listbox_VehicleType.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(258, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_Subscriber
            // 
            this.checkBox_Subscriber.AutoSize = true;
            this.checkBox_Subscriber.Location = new System.Drawing.Point(196, 162);
            this.checkBox_Subscriber.Name = "checkBox_Subscriber";
            this.checkBox_Subscriber.Size = new System.Drawing.Size(76, 17);
            this.checkBox_Subscriber.TabIndex = 6;
            this.checkBox_Subscriber.Text = "Subscriber";
            this.checkBox_Subscriber.UseVisualStyleBackColor = true;
            // 
            // checkBox_Contact
            // 
            this.checkBox_Contact.AutoSize = true;
            this.checkBox_Contact.Location = new System.Drawing.Point(106, 162);
            this.checkBox_Contact.Name = "checkBox_Contact";
            this.checkBox_Contact.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Contact.TabIndex = 5;
            this.checkBox_Contact.Text = "Contact ";
            this.checkBox_Contact.UseVisualStyleBackColor = true;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(25, 92);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(75, 13);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Vehicle Type :";
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Location = new System.Drawing.Point(106, 41);
            this.txtPlateNo.Multiline = true;
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(166, 25);
            this.txtPlateNo.TabIndex = 2;
            // 
            // label_plate
            // 
            this.label_plate.AutoSize = true;
            this.label_plate.Location = new System.Drawing.Point(25, 44);
            this.label_plate.Name = "label_plate";
            this.label_plate.Size = new System.Drawing.Size(54, 13);
            this.label_plate.TabIndex = 1;
            this.label_plate.Text = "Plate No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Vehicles);
            this.groupBox2.Location = new System.Drawing.Point(383, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parking Vehicles";
            // 
            // listBox_Vehicles
            // 
            this.listBox_Vehicles.ContextMenuStrip = this.contextMenuStrip;
            this.listBox_Vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Vehicles.FormattingEnabled = true;
            this.listBox_Vehicles.ItemHeight = 16;
            this.listBox_Vehicles.Location = new System.Drawing.Point(9, 24);
            this.listBox_Vehicles.Name = "listBox_Vehicles";
            this.listBox_Vehicles.Size = new System.Drawing.Size(400, 388);
            this.listBox_Vehicles.TabIndex = 0;
            this.listBox_Vehicles.SelectedIndexChanged += new System.EventHandler(this.listBox_Vehicles_SelectedIndexChanged);
            this.listBox_Vehicles.ContextMenuStripChanged += new System.EventHandler(this.listBox_Vehicles_ContextMenuStripChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_dailyreport);
            this.groupBox3.Controls.Add(this.lbl_fee);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbl_hour);
            this.groupBox3.Controls.Add(this.lbl_plate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(24, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // button_dailyreport
            // 
            this.button_dailyreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dailyreport.Location = new System.Drawing.Point(61, 150);
            this.button_dailyreport.Name = "button_dailyreport";
            this.button_dailyreport.Size = new System.Drawing.Size(226, 30);
            this.button_dailyreport.TabIndex = 10;
            this.button_dailyreport.Text = "Daily Sales Raport";
            this.button_dailyreport.UseVisualStyleBackColor = true;
            this.button_dailyreport.Click += new System.EventHandler(this.button_dailyreport_Click);
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoSize = true;
            this.lbl_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fee.Location = new System.Drawing.Point(125, 115);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(57, 20);
            this.lbl_fee.TabIndex = 9;
            this.lbl_fee.Text = "0 EUR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fee :";
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.Location = new System.Drawing.Point(125, 76);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(57, 20);
            this.lbl_hour.TabIndex = 7;
            this.lbl_hour.Text = "0 Hour";
            // 
            // lbl_plate
            // 
            this.lbl_plate.AutoSize = true;
            this.lbl_plate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plate.Location = new System.Drawing.Point(125, 38);
            this.lbl_plate.Name = "lbl_plate";
            this.lbl_plate.Size = new System.Drawing.Size(75, 20);
            this.lbl_plate.TabIndex = 6;
            this.lbl_plate.Text = "00 XX 00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plate No :";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.contextMenuStrip.Name = "Reports";
            this.contextMenuStrip.Size = new System.Drawing.Size(133, 26);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.reportsToolStripMenuItem.Text = "Exit Vehicle";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Subscriber;
        private System.Windows.Forms.CheckBox checkBox_Contact;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox txtPlateNo;
        private System.Windows.Forms.Label label_plate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_Vehicles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_dailyreport;
        private System.Windows.Forms.Label lbl_fee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label lbl_plate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listbox_VehicleType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}


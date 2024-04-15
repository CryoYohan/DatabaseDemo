namespace DatabaseManagementDemo
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
            this.vehiclesDB = new System.Windows.Forms.DataGridView();
            this.plateNoBox = new System.Windows.Forms.TextBox();
            this.vehicleBrandBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editPanel = new System.Windows.Forms.Panel();
            this.editBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editVB = new System.Windows.Forms.TextBox();
            this.editVT = new System.Windows.Forms.TextBox();
            this.editPN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesDB
            // 
            this.vehiclesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDB.Location = new System.Drawing.Point(435, 60);
            this.vehiclesDB.Name = "vehiclesDB";
            this.vehiclesDB.Size = new System.Drawing.Size(496, 372);
            this.vehiclesDB.TabIndex = 0;
            this.vehiclesDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiclesDB_CellContentClick);
            this.vehiclesDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiclesDB_CellContentClick);
            // 
            // plateNoBox
            // 
            this.plateNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.plateNoBox.Location = new System.Drawing.Point(41, 89);
            this.plateNoBox.Name = "plateNoBox";
            this.plateNoBox.Size = new System.Drawing.Size(216, 30);
            this.plateNoBox.TabIndex = 1;
            // 
            // vehicleBrandBox
            // 
            this.vehicleBrandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vehicleBrandBox.Location = new System.Drawing.Point(41, 270);
            this.vehicleBrandBox.Name = "vehicleBrandBox";
            this.vehicleBrandBox.Size = new System.Drawing.Size(216, 30);
            this.vehicleBrandBox.TabIndex = 2;
            // 
            // vehicleTypeBox
            // 
            this.vehicleTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vehicleTypeBox.Location = new System.Drawing.Point(41, 169);
            this.vehicleTypeBox.Name = "vehicleTypeBox";
            this.vehicleTypeBox.Size = new System.Drawing.Size(216, 30);
            this.vehicleTypeBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLATE NO.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VEHICLE TYPE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "VEHICLE BRAND";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Location = new System.Drawing.Point(65, 334);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(159, 48);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(715, 458);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search Plate No.";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(DatabaseManagementDemo.Program);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(DatabaseManagementDemo.Program);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editBTN);
            this.editPanel.Controls.Add(this.label7);
            this.editPanel.Controls.Add(this.label6);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.editVB);
            this.editPanel.Controls.Add(this.editVT);
            this.editPanel.Controls.Add(this.editPN);
            this.editPanel.Location = new System.Drawing.Point(358, 108);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(334, 240);
            this.editPanel.TabIndex = 10;
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(229, 195);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(74, 25);
            this.editBTN.TabIndex = 6;
            this.editBTN.Text = "Done";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Vehicle Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vehicle Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Plate No.";
            // 
            // editVB
            // 
            this.editVB.Location = new System.Drawing.Point(89, 162);
            this.editVB.Name = "editVB";
            this.editVB.Size = new System.Drawing.Size(123, 20);
            this.editVB.TabIndex = 2;
            // 
            // editVT
            // 
            this.editVT.Location = new System.Drawing.Point(89, 107);
            this.editVT.Name = "editVT";
            this.editVT.Size = new System.Drawing.Size(123, 20);
            this.editVT.TabIndex = 1;
            // 
            // editPN
            // 
            this.editPN.Location = new System.Drawing.Point(89, 48);
            this.editPN.Name = "editPN";
            this.editPN.Size = new System.Drawing.Size(123, 20);
            this.editPN.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 526);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleTypeBox);
            this.Controls.Add(this.vehicleBrandBox);
            this.Controls.Add(this.plateNoBox);
            this.Controls.Add(this.vehiclesDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehiclesDB;
        private System.Windows.Forms.TextBox plateNoBox;
        private System.Windows.Forms.TextBox vehicleBrandBox;
        private System.Windows.Forms.TextBox vehicleTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editVB;
        private System.Windows.Forms.TextBox editVT;
        private System.Windows.Forms.TextBox editPN;
    }
}


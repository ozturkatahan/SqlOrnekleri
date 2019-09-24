namespace SqlOrnekleri
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCountryResult = new System.Windows.Forms.Label();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeTitle = new System.Windows.Forms.Label();
            this.lblCountrylbl = new System.Windows.Forms.Label();
            this.txtEmployeeTitle = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCalisanlariGetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(667, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(606, 35);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country";
            // 
            // lblCountryResult
            // 
            this.lblCountryResult.AutoSize = true;
            this.lblCountryResult.Location = new System.Drawing.Point(581, 76);
            this.lblCountryResult.Name = "lblCountryResult";
            this.lblCountryResult.Size = new System.Drawing.Size(68, 13);
            this.lblCountryResult.TabIndex = 3;
            this.lblCountryResult.Text = "Sipariş Sayısı";
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(11, 9);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(106, 13);
            this.lblEmployeeFirstName.TabIndex = 4;
            this.lblEmployeeFirstName.Text = "Employee First Name";
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.Location = new System.Drawing.Point(11, 45);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(107, 13);
            this.lblEmployeeLastName.TabIndex = 5;
            this.lblEmployeeLastName.Text = "Employee Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // lblEmployeeTitle
            // 
            this.lblEmployeeTitle.AutoSize = true;
            this.lblEmployeeTitle.Location = new System.Drawing.Point(11, 80);
            this.lblEmployeeTitle.Name = "lblEmployeeTitle";
            this.lblEmployeeTitle.Size = new System.Drawing.Size(76, 13);
            this.lblEmployeeTitle.TabIndex = 8;
            this.lblEmployeeTitle.Text = "Employee Title";
            // 
            // lblCountrylbl
            // 
            this.lblCountrylbl.AutoSize = true;
            this.lblCountrylbl.Location = new System.Drawing.Point(12, 116);
            this.lblCountrylbl.Name = "lblCountrylbl";
            this.lblCountrylbl.Size = new System.Drawing.Size(43, 13);
            this.lblCountrylbl.TabIndex = 9;
            this.lblCountrylbl.Text = "Country";
            // 
            // txtEmployeeTitle
            // 
            this.txtEmployeeTitle.Location = new System.Drawing.Point(124, 77);
            this.txtEmployeeTitle.Name = "txtEmployeeTitle";
            this.txtEmployeeTitle.Size = new System.Drawing.Size(121, 20);
            this.txtEmployeeTitle.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(124, 109);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(121, 20);
            this.txtCountry.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(261, 6);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeId.TabIndex = 13;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(264, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(124, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(334, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 18;
            // 
            // btnCalisanlariGetir
            // 
            this.btnCalisanlariGetir.Location = new System.Drawing.Point(290, 360);
            this.btnCalisanlariGetir.Name = "btnCalisanlariGetir";
            this.btnCalisanlariGetir.Size = new System.Drawing.Size(217, 35);
            this.btnCalisanlariGetir.TabIndex = 19;
            this.btnCalisanlariGetir.Text = "Çalışanları Getir";
            this.btnCalisanlariGetir.UseVisualStyleBackColor = true;
            this.btnCalisanlariGetir.Click += new System.EventHandler(this.btnCalisanlariGetir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 264);
            this.listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCalisanlariGetir);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtEmployeeTitle);
            this.Controls.Add(this.lblCountrylbl);
            this.Controls.Add(this.lblEmployeeTitle);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.lblEmployeeFirstName);
            this.Controls.Add(this.lblCountryResult);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCountryResult;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmployeeTitle;
        private System.Windows.Forms.Label lblCountrylbl;
        private System.Windows.Forms.TextBox txtEmployeeTitle;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCalisanlariGetir;
        private System.Windows.Forms.ListBox listBox1;
    }
}


namespace CustomerContactForm
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
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.btnAddNewCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCustName = new System.Windows.Forms.TextBox();
            this.txbLat = new System.Windows.Forms.TextBox();
            this.txbLong = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCustContName = new System.Windows.Forms.TextBox();
            this.txbCustContEmail = new System.Windows.Forms.TextBox();
            this.txbCustContNum = new System.Windows.Forms.TextBox();
            this.btnBackOne = new System.Windows.Forms.Button();
            this.btnForwardOne = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblContactTotal = new System.Windows.Forms.Label();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnCustDelete = new System.Windows.Forms.Button();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.btnContDelete = new System.Windows.Forms.Button();
            this.lblContactCount = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.gbCustomer.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCustomers
            // 
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(27, 41);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(154, 21);
            this.cbCustomers.TabIndex = 0;
            this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
            // 
            // btnAddNewCust
            // 
            this.btnAddNewCust.Location = new System.Drawing.Point(206, 41);
            this.btnAddNewCust.Name = "btnAddNewCust";
            this.btnAddNewCust.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewCust.TabIndex = 1;
            this.btnAddNewCust.Text = "Add New";
            this.btnAddNewCust.UseVisualStyleBackColor = true;
            this.btnAddNewCust.Click += new System.EventHandler(this.btnAddNewCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 160);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Longitude";
            // 
            // txbCustName
            // 
            this.txbCustName.Location = new System.Drawing.Point(94, 109);
            this.txbCustName.MaxLength = 200;
            this.txbCustName.Name = "txbCustName";
            this.txbCustName.Size = new System.Drawing.Size(187, 20);
            this.txbCustName.TabIndex = 2;
            // 
            // txbLat
            // 
            this.txbLat.Location = new System.Drawing.Point(94, 136);
            this.txbLat.Name = "txbLat";
            this.txbLat.Size = new System.Drawing.Size(187, 20);
            this.txbLat.TabIndex = 3;
            // 
            // txbLong
            // 
            this.txbLong.Location = new System.Drawing.Point(94, 163);
            this.txbLong.Name = "txbLong";
            this.txbLong.Size = new System.Drawing.Size(187, 20);
            this.txbLong.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact Number";
            // 
            // txbCustContName
            // 
            this.txbCustContName.Location = new System.Drawing.Point(131, 71);
            this.txbCustContName.Name = "txbCustContName";
            this.txbCustContName.Size = new System.Drawing.Size(196, 20);
            this.txbCustContName.TabIndex = 9;
            // 
            // txbCustContEmail
            // 
            this.txbCustContEmail.Location = new System.Drawing.Point(131, 99);
            this.txbCustContEmail.Name = "txbCustContEmail";
            this.txbCustContEmail.Size = new System.Drawing.Size(196, 20);
            this.txbCustContEmail.TabIndex = 10;
            // 
            // txbCustContNum
            // 
            this.txbCustContNum.Location = new System.Drawing.Point(131, 129);
            this.txbCustContNum.Name = "txbCustContNum";
            this.txbCustContNum.Size = new System.Drawing.Size(196, 20);
            this.txbCustContNum.TabIndex = 11;
            // 
            // btnBackOne
            // 
            this.btnBackOne.Location = new System.Drawing.Point(168, 180);
            this.btnBackOne.Name = "btnBackOne";
            this.btnBackOne.Size = new System.Drawing.Size(32, 23);
            this.btnBackOne.TabIndex = 12;
            this.btnBackOne.Text = "<";
            this.btnBackOne.UseVisualStyleBackColor = true;
            this.btnBackOne.Click += new System.EventHandler(this.btnBackOne_Click);
            // 
            // btnForwardOne
            // 
            this.btnForwardOne.Location = new System.Drawing.Point(263, 180);
            this.btnForwardOne.Name = "btnForwardOne";
            this.btnForwardOne.Size = new System.Drawing.Size(34, 23);
            this.btnForwardOne.TabIndex = 13;
            this.btnForwardOne.Text = ">";
            this.btnForwardOne.UseVisualStyleBackColor = true;
            this.btnForwardOne.Click += new System.EventHandler(this.btnForwardOne_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(124, 180);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(38, 23);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(303, 180);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 23);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblContactTotal
            // 
            this.lblContactTotal.AutoSize = true;
            this.lblContactTotal.Location = new System.Drawing.Point(223, 185);
            this.lblContactTotal.Name = "lblContactTotal";
            this.lblContactTotal.Size = new System.Drawing.Size(22, 13);
            this.lblContactTotal.TabIndex = 16;
            this.lblContactTotal.Text = " of ";
            // 
            // btnNewContact
            // 
            this.btnNewContact.Location = new System.Drawing.Point(187, 38);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact.TabIndex = 17;
            this.btnNewContact.Text = "New";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Location = new System.Drawing.Point(263, 231);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(75, 23);
            this.btnSaveContact.TabIndex = 18;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblCustID);
            this.gbCustomer.Controls.Add(this.btnCustDelete);
            this.gbCustomer.Controls.Add(this.txbCustName);
            this.gbCustomer.Controls.Add(this.cbCustomers);
            this.gbCustomer.Controls.Add(this.btnAddNewCust);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.label4);
            this.gbCustomer.Controls.Add(this.txbLat);
            this.gbCustomer.Controls.Add(this.txbLong);
            this.gbCustomer.Controls.Add(this.btnSave);
            this.gbCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(336, 255);
            this.gbCustomer.TabIndex = 19;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // btnCustDelete
            // 
            this.btnCustDelete.Location = new System.Drawing.Point(25, 190);
            this.btnCustDelete.Name = "btnCustDelete";
            this.btnCustDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustDelete.TabIndex = 6;
            this.btnCustDelete.Text = "Delete";
            this.btnCustDelete.UseVisualStyleBackColor = true;
            this.btnCustDelete.Click += new System.EventHandler(this.btnCustDelete_Click);
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.btnContDelete);
            this.gbContact.Controls.Add(this.lblContactCount);
            this.gbContact.Controls.Add(this.txbCustContEmail);
            this.gbContact.Controls.Add(this.label5);
            this.gbContact.Controls.Add(this.btnSaveContact);
            this.gbContact.Controls.Add(this.label6);
            this.gbContact.Controls.Add(this.btnNewContact);
            this.gbContact.Controls.Add(this.label7);
            this.gbContact.Controls.Add(this.lblContactTotal);
            this.gbContact.Controls.Add(this.txbCustContName);
            this.gbContact.Controls.Add(this.btnLast);
            this.gbContact.Controls.Add(this.txbCustContNum);
            this.gbContact.Controls.Add(this.btnFirst);
            this.gbContact.Controls.Add(this.btnBackOne);
            this.gbContact.Controls.Add(this.btnForwardOne);
            this.gbContact.Location = new System.Drawing.Point(390, 13);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(377, 331);
            this.gbContact.TabIndex = 20;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Customer Contact";
            // 
            // btnContDelete
            // 
            this.btnContDelete.Location = new System.Drawing.Point(124, 230);
            this.btnContDelete.Name = "btnContDelete";
            this.btnContDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContDelete.TabIndex = 20;
            this.btnContDelete.Text = "Delete";
            this.btnContDelete.UseVisualStyleBackColor = true;
            this.btnContDelete.Click += new System.EventHandler(this.btnContDelete_Click);
            // 
            // lblContactCount
            // 
            this.lblContactCount.AutoSize = true;
            this.lblContactCount.Location = new System.Drawing.Point(207, 185);
            this.lblContactCount.Name = "lblContactCount";
            this.lblContactCount.Size = new System.Drawing.Size(10, 13);
            this.lblContactCount.TabIndex = 19;
            this.lblContactCount.Text = "-";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(93, 79);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblCustID.Size = new System.Drawing.Size(10, 23);
            this.lblCustID.TabIndex = 7;
            this.lblCustID.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 447);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.gbCustomer);
            this.Name = "Form1";
            this.Text = "Customer Contact Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.Button btnAddNewCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCustName;
        private System.Windows.Forms.TextBox txbLat;
        private System.Windows.Forms.TextBox txbLong;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCustContName;
        private System.Windows.Forms.TextBox txbCustContEmail;
        private System.Windows.Forms.TextBox txbCustContNum;
        private System.Windows.Forms.Button btnBackOne;
        private System.Windows.Forms.Button btnForwardOne;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblContactTotal;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.Label lblContactCount;
        private System.Windows.Forms.Button btnCustDelete;
        private System.Windows.Forms.Button btnContDelete;
        private System.Windows.Forms.Label lblCustID;
    }
}


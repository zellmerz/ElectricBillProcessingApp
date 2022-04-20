
namespace CustomerDataGUI
{
    partial class frmCustomerData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCustData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtKWH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustProc = new System.Windows.Forms.Label();
            this.lblAVGBill = new System.Windows.Forms.Label();
            this.lblKWHBilled = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustData
            // 
            this.lstCustData.FormattingEnabled = true;
            this.lstCustData.ItemHeight = 25;
            this.lstCustData.Location = new System.Drawing.Point(395, 22);
            this.lstCustData.Name = "lstCustData";
            this.lstCustData.Size = new System.Drawing.Size(727, 629);
            this.lstCustData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "kWh Used:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(30, 55);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(312, 33);
            this.txtFName.TabIndex = 4;
            this.txtFName.Tag = "First Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(30, 173);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(312, 33);
            this.txtLName.TabIndex = 5;
            this.txtLName.Tag = "Last Name";
            // 
            // txtKWH
            // 
            this.txtKWH.Location = new System.Drawing.Point(30, 298);
            this.txtKWH.Name = "txtKWH";
            this.txtKWH.Size = new System.Drawing.Size(149, 33);
            this.txtKWH.TabIndex = 6;
            this.txtKWH.Tag = "kWh Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "# of Customers Processed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total kWh billed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 663);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Average Bill Amount:";
            // 
            // lblCustProc
            // 
            this.lblCustProc.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCustProc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustProc.Location = new System.Drawing.Point(96, 464);
            this.lblCustProc.Name = "lblCustProc";
            this.lblCustProc.Size = new System.Drawing.Size(165, 42);
            this.lblCustProc.TabIndex = 10;
            this.lblCustProc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAVGBill
            // 
            this.lblAVGBill.BackColor = System.Drawing.Color.AliceBlue;
            this.lblAVGBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAVGBill.Location = new System.Drawing.Point(96, 716);
            this.lblAVGBill.Name = "lblAVGBill";
            this.lblAVGBill.Size = new System.Drawing.Size(165, 42);
            this.lblAVGBill.TabIndex = 11;
            this.lblAVGBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKWHBilled
            // 
            this.lblKWHBilled.BackColor = System.Drawing.Color.AliceBlue;
            this.lblKWHBilled.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKWHBilled.Location = new System.Drawing.Point(96, 596);
            this.lblKWHBilled.Name = "lblKWHBilled";
            this.lblKWHBilled.Size = new System.Drawing.Size(165, 42);
            this.lblKWHBilled.TabIndex = 12;
            this.lblKWHBilled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 51);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(981, 707);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 51);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomerData
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1143, 782);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblKWHBilled);
            this.Controls.Add(this.lblAVGBill);
            this.Controls.Add(this.lblCustProc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKWH);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustData);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCustomerData";
            this.Text = "Customer Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtKWH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustProc;
        private System.Windows.Forms.Label lblAVGBill;
        private System.Windows.Forms.Label lblKWHBilled;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}


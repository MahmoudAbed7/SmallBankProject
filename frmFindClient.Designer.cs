namespace BankWindowsForm
{
    partial class frmFindClient
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lvFindClient = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnSerach = new System.Windows.Forms.Button();
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(42, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(39, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "???";
            // 
            // lvFindClient
            // 
            this.lvFindClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFirstName,
            this.chLastName,
            this.chEmail,
            this.chPhone,
            this.chAddress,
            this.chAccountNumber,
            this.chAccBalance});
            this.lvFindClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvFindClient.HideSelection = false;
            this.lvFindClient.Location = new System.Drawing.Point(0, 175);
            this.lvFindClient.Name = "lvFindClient";
            this.lvFindClient.Size = new System.Drawing.Size(800, 275);
            this.lvFindClient.TabIndex = 2;
            this.lvFindClient.UseCompatibleStateImageBehavior = false;
            this.lvFindClient.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by name:";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(417, 81);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtNameSearch.TabIndex = 4;
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(331, 118);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(120, 37);
            this.btnSerach.TabIndex = 5;
            this.btnSerach.Text = "Search";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "FirstName";
            // 
            // chLastName
            // 
            this.chLastName.Text = "LastName";
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            // 
            // chPhone
            // 
            this.chPhone.Text = "Phone";
            // 
            // chAddress
            // 
            this.chAddress.Text = "Address";
            // 
            // chAccountNumber
            // 
            this.chAccountNumber.Text = "AccNumber";
            // 
            // chAccBalance
            // 
            this.chAccBalance.Text = "AccBalance";
            // 
            // frmFindClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFindClient);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmFindClient";
            this.Text = "frmFindClient";
            this.Load += new System.EventHandler(this.frmFindClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ListView lvFindClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chAccountNumber;
        private System.Windows.Forms.ColumnHeader chAccBalance;
    }
}
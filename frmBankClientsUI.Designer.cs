namespace BankWindowsForm
{
    partial class frmBankClientsUI
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
            this.btnShowClientList = new System.Windows.Forms.Button();
            this.btnShowUserList = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(57, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(39, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "???";
            // 
            // btnShowClientList
            // 
            this.btnShowClientList.Location = new System.Drawing.Point(259, 90);
            this.btnShowClientList.Name = "btnShowClientList";
            this.btnShowClientList.Size = new System.Drawing.Size(98, 41);
            this.btnShowClientList.TabIndex = 1;
            this.btnShowClientList.Text = "Show Client List";
            this.btnShowClientList.UseVisualStyleBackColor = true;
            this.btnShowClientList.Click += new System.EventHandler(this.btnShowClientList_Click);
            // 
            // btnShowUserList
            // 
            this.btnShowUserList.Location = new System.Drawing.Point(363, 90);
            this.btnShowUserList.Name = "btnShowUserList";
            this.btnShowUserList.Size = new System.Drawing.Size(98, 41);
            this.btnShowUserList.TabIndex = 2;
            this.btnShowUserList.Text = "Show User List";
            this.btnShowUserList.UseVisualStyleBackColor = true;
            this.btnShowUserList.Click += new System.EventHandler(this.btnShowUserList_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(259, 137);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(98, 41);
            this.btnFindClient.TabIndex = 3;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(363, 137);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(98, 41);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // frmBankClientsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.btnShowUserList);
            this.Controls.Add(this.btnShowClientList);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmBankClientsUI";
            this.Text = "frmBankClientsUI";
            this.Load += new System.EventHandler(this.frmBankClientsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnShowClientList;
        private System.Windows.Forms.Button btnShowUserList;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnTransaction;
    }
}
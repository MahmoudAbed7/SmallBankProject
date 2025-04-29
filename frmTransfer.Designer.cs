namespace BankWindowsForm
{
    partial class frmTransfer
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAcountBalance = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRecieveAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecieveAccBalance = new System.Windows.Forms.Label();
            this.lblRecieveAccNum = new System.Windows.Forms.Label();
            this.lblRecieveName = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(28, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(39, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "???";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 163);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "FullName";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(51, 198);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(137, 20);
            this.lblAccountNumber.TabIndex = 5;
            this.lblAccountNumber.Text = "AccountNumber";
            // 
            // lblAcountBalance
            // 
            this.lblAcountBalance.AutoSize = true;
            this.lblAcountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcountBalance.Location = new System.Drawing.Point(51, 232);
            this.lblAcountBalance.Name = "lblAcountBalance";
            this.lblAcountBalance.Size = new System.Drawing.Size(140, 20);
            this.lblAcountBalance.TabIndex = 6;
            this.lblAcountBalance.Text = "AccountBalance";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(55, 109);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(120, 37);
            this.btnGet.TabIndex = 9;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(264, 78);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Deliver Account Number:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRecieveAccountNumber
            // 
            this.txtRecieveAccountNumber.Location = new System.Drawing.Point(639, 76);
            this.txtRecieveAccountNumber.Name = "txtRecieveAccountNumber";
            this.txtRecieveAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRecieveAccountNumber.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recieve Account Number:";
            // 
            // lblRecieveAccBalance
            // 
            this.lblRecieveAccBalance.AutoSize = true;
            this.lblRecieveAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieveAccBalance.Location = new System.Drawing.Point(417, 232);
            this.lblRecieveAccBalance.Name = "lblRecieveAccBalance";
            this.lblRecieveAccBalance.Size = new System.Drawing.Size(140, 20);
            this.lblRecieveAccBalance.TabIndex = 15;
            this.lblRecieveAccBalance.Text = "AccountBalance";
            // 
            // lblRecieveAccNum
            // 
            this.lblRecieveAccNum.AutoSize = true;
            this.lblRecieveAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieveAccNum.Location = new System.Drawing.Point(417, 198);
            this.lblRecieveAccNum.Name = "lblRecieveAccNum";
            this.lblRecieveAccNum.Size = new System.Drawing.Size(137, 20);
            this.lblRecieveAccNum.TabIndex = 14;
            this.lblRecieveAccNum.Text = "AccountNumber";
            // 
            // lblRecieveName
            // 
            this.lblRecieveName.AutoSize = true;
            this.lblRecieveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieveName.Location = new System.Drawing.Point(417, 163);
            this.lblRecieveName.Name = "lblRecieveName";
            this.lblRecieveName.Size = new System.Drawing.Size(84, 20);
            this.lblRecieveName.TabIndex = 13;
            this.lblRecieveName.Text = "FullName";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(244, 314);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(120, 37);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(133, 323);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 18;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblRecieveAccBalance);
            this.Controls.Add(this.lblRecieveAccNum);
            this.Controls.Add(this.lblRecieveName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRecieveAccountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAcountBalance);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAcountBalance;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRecieveAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecieveAccBalance;
        private System.Windows.Forms.Label lblRecieveAccNum;
        private System.Windows.Forms.Label lblRecieveName;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
    }
}
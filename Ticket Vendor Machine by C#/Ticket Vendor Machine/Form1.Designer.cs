namespace Ticket_Vendor_Machine
{
    partial class TicketM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketM));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnQRcode = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTran = new System.Windows.Forms.ComboBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.grbBuy = new System.Windows.Forms.GroupBox();
            this.grbDes = new System.Windows.Forms.GroupBox();
            this.dGVDes = new System.Windows.Forms.DataGridView();
            this.grbBuy.SuspendLayout();
            this.grbDes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(360, 112);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 26);
            this.txtQuan.TabIndex = 2;
            this.txtQuan.TextChanged += new System.EventHandler(this.txtQuan_TextChanged);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(168, 168);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(136, 56);
            this.btnCredit.TabIndex = 3;
            this.btnCredit.Text = "Credit Card";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnQRcode
            // 
            this.btnQRcode.Location = new System.Drawing.Point(376, 168);
            this.btnQRcode.Name = "btnQRcode";
            this.btnQRcode.Size = new System.Drawing.Size(136, 56);
            this.btnQRcode.TabIndex = 3;
            this.btnQRcode.Text = "QR code";
            this.btnQRcode.UseVisualStyleBackColor = true;
            this.btnQRcode.Click += new System.EventHandler(this.btnQRcode_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(568, 168);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(136, 56);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Transport";
            // 
            // cmbTran
            // 
            this.cmbTran.FormattingEnabled = true;
            this.cmbTran.Items.AddRange(new object[] {
            "Bus",
            "Train",
            "Test1",
            "Test2"});
            this.cmbTran.Location = new System.Drawing.Point(360, 16);
            this.cmbTran.Name = "cmbTran";
            this.cmbTran.Size = new System.Drawing.Size(240, 28);
            this.cmbTran.TabIndex = 1;
            this.cmbTran.SelectedIndexChanged += new System.EventHandler(this.cmbTran_SelectedIndexChanged);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(360, 64);
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.Size = new System.Drawing.Size(240, 26);
            this.txtDes.TabIndex = 4;
            // 
            // grbBuy
            // 
            this.grbBuy.Controls.Add(this.btnRef);
            this.grbBuy.Controls.Add(this.txtDes);
            this.grbBuy.Controls.Add(this.label1);
            this.grbBuy.Controls.Add(this.label2);
            this.grbBuy.Controls.Add(this.btnQRcode);
            this.grbBuy.Controls.Add(this.label3);
            this.grbBuy.Controls.Add(this.btnCredit);
            this.grbBuy.Controls.Add(this.cmbTran);
            this.grbBuy.Controls.Add(this.txtQuan);
            this.grbBuy.Location = new System.Drawing.Point(8, 8);
            this.grbBuy.Name = "grbBuy";
            this.grbBuy.Size = new System.Drawing.Size(816, 264);
            this.grbBuy.TabIndex = 5;
            this.grbBuy.TabStop = false;
            this.grbBuy.Text = "Buy a Ticket";
            // 
            // grbDes
            // 
            this.grbDes.Controls.Add(this.dGVDes);
            this.grbDes.Location = new System.Drawing.Point(8, 296);
            this.grbDes.Name = "grbDes";
            this.grbDes.Size = new System.Drawing.Size(816, 288);
            this.grbDes.TabIndex = 6;
            this.grbDes.TabStop = false;
            this.grbDes.Text = "Destinations";
            // 
            // dGVDes
            // 
            this.dGVDes.AllowUserToAddRows = false;
            this.dGVDes.AllowUserToDeleteRows = false;
            this.dGVDes.AllowUserToResizeColumns = false;
            this.dGVDes.AllowUserToResizeRows = false;
            this.dGVDes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDes.Location = new System.Drawing.Point(16, 24);
            this.dGVDes.Name = "dGVDes";
            this.dGVDes.RowHeadersVisible = false;
            this.dGVDes.RowHeadersWidth = 62;
            this.dGVDes.RowTemplate.Height = 28;
            this.dGVDes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDes.Size = new System.Drawing.Size(792, 264);
            this.dGVDes.TabIndex = 0;
            this.dGVDes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDes_CellClick);
            // 
            // TicketM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 590);
            this.Controls.Add(this.grbDes);
            this.Controls.Add(this.grbBuy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketM";
            this.Text = "Ticket Vendor Machine";
            this.Load += new System.EventHandler(this.TicketM_Load);
            this.grbBuy.ResumeLayout(false);
            this.grbBuy.PerformLayout();
            this.grbDes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnQRcode;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTran;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.GroupBox grbBuy;
        private System.Windows.Forms.GroupBox grbDes;
        private System.Windows.Forms.DataGridView dGVDes;
    }
}


namespace Ticket_Vendor_Machine
{
    partial class Credit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credit));
            this.tabInput = new System.Windows.Forms.TabControl();
            this.tabPhysical = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabInp = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.tabInput.SuspendLayout();
            this.tabPhysical.SuspendLayout();
            this.tabInp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.tabPhysical);
            this.tabInput.Controls.Add(this.tabInp);
            this.tabInput.Location = new System.Drawing.Point(48, 48);
            this.tabInput.Name = "tabInput";
            this.tabInput.SelectedIndex = 0;
            this.tabInput.Size = new System.Drawing.Size(504, 296);
            this.tabInput.TabIndex = 0;
            // 
            // tabPhysical
            // 
            this.tabPhysical.Controls.Add(this.button1);
            this.tabPhysical.Location = new System.Drawing.Point(4, 29);
            this.tabPhysical.Name = "tabPhysical";
            this.tabPhysical.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhysical.Size = new System.Drawing.Size(496, 263);
            this.tabPhysical.TabIndex = 0;
            this.tabPhysical.Text = "Card Physical";
            this.tabPhysical.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabInp
            // 
            this.tabInp.Controls.Add(this.btnSubmit);
            this.tabInp.Controls.Add(this.label4);
            this.tabInp.Controls.Add(this.txtCvv);
            this.tabInp.Controls.Add(this.label3);
            this.tabInp.Controls.Add(this.txtExp);
            this.tabInp.Controls.Add(this.label2);
            this.tabInp.Controls.Add(this.txtName);
            this.tabInp.Controls.Add(this.label1);
            this.tabInp.Controls.Add(this.txtNumber);
            this.tabInp.Location = new System.Drawing.Point(4, 29);
            this.tabInp.Name = "tabInp";
            this.tabInp.Padding = new System.Windows.Forms.Padding(3);
            this.tabInp.Size = new System.Drawing.Size(496, 263);
            this.tabInp.TabIndex = 1;
            this.tabInp.Text = "Input Card";
            this.tabInp.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(232, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 40);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cvv";
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(192, 152);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(56, 26);
            this.txtCvv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exp Date";
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(192, 112);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(192, 26);
            this.txtExp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 26);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(192, 34);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(192, 26);
            this.txtNumber.TabIndex = 0;
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 396);
            this.ControlBox = false;
            this.Controls.Add(this.tabInput);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Credit";
            this.Text = "Payment by Credit Card";
            this.Load += new System.EventHandler(this.Credit_Load);
            this.tabInput.ResumeLayout(false);
            this.tabPhysical.ResumeLayout(false);
            this.tabInp.ResumeLayout(false);
            this.tabInp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInput;
        private System.Windows.Forms.TabPage tabPhysical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCvv;
    }
}
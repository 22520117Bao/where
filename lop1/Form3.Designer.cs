namespace lop1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcb1 = new System.Windows.Forms.ComboBox();
            this.txtcb2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.cd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUY ĐỎI TIỀN TỆ ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sang";
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(265, 49);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(226, 20);
            this.txttien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá trị ";
            // 
            // txtcb1
            // 
            this.txtcb1.FormattingEnabled = true;
            this.txtcb1.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.txtcb1.Location = new System.Drawing.Point(170, 97);
            this.txtcb1.Name = "txtcb1";
            this.txtcb1.Size = new System.Drawing.Size(121, 21);
            this.txtcb1.TabIndex = 7;
            this.txtcb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtcb2
            // 
            this.txtcb2.FormattingEnabled = true;
            this.txtcb2.Items.AddRange(new object[] {
            "VND"});
            this.txtcb2.Location = new System.Drawing.Point(468, 98);
            this.txtcb2.Name = "txtcb2";
            this.txtcb2.Size = new System.Drawing.Size(121, 21);
            this.txtcb2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết quả ";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(265, 281);
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(226, 20);
            this.txtkq.TabIndex = 10;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // cd
            // 
            this.cd.Location = new System.Drawing.Point(207, 157);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(226, 23);
            this.cd.TabIndex = 11;
            this.cd.Text = "Chuyển đổi ";
            this.cd.UseVisualStyleBackColor = true;
            this.cd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cd);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcb2);
            this.Controls.Add(this.txtcb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtcb1;
        private System.Windows.Forms.ComboBox txtcb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button cd;
    }
}
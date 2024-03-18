namespace lop1
{
    partial class Form4
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.gtribut = new System.Windows.Forms.Button();
            this.xoabut = new System.Windows.Forms.Button();
            this.escbut = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(209, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tinh toan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhap B";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(212, 82);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(135, 20);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(486, 86);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(164, 20);
            this.txtb.TabIndex = 4;
            // 
            // gtribut
            // 
            this.gtribut.Location = new System.Drawing.Point(132, 181);
            this.gtribut.Name = "gtribut";
            this.gtribut.Size = new System.Drawing.Size(199, 23);
            this.gtribut.TabIndex = 5;
            this.gtribut.Text = "Tính các giá trị ";
            this.gtribut.UseVisualStyleBackColor = true;
            this.gtribut.Click += new System.EventHandler(this.gtribut_Click);
            // 
            // xoabut
            // 
            this.xoabut.Location = new System.Drawing.Point(419, 181);
            this.xoabut.Name = "xoabut";
            this.xoabut.Size = new System.Drawing.Size(75, 23);
            this.xoabut.TabIndex = 6;
            this.xoabut.Text = "Xóa";
            this.xoabut.UseVisualStyleBackColor = true;
            this.xoabut.Click += new System.EventHandler(this.xoabut_Click);
            // 
            // escbut
            // 
            this.escbut.Location = new System.Drawing.Point(594, 181);
            this.escbut.Name = "escbut";
            this.escbut.Size = new System.Drawing.Size(75, 23);
            this.escbut.TabIndex = 7;
            this.escbut.Text = "Thoát";
            this.escbut.UseVisualStyleBackColor = true;
            this.escbut.Click += new System.EventHandler(this.escbut_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(209, 243);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(365, 117);
            this.txtkq.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.escbut);
            this.Controls.Add(this.xoabut);
            this.Controls.Add(this.gtribut);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button gtribut;
        private System.Windows.Forms.Button xoabut;
        private System.Windows.Forms.Button escbut;
        private System.Windows.Forms.Label txtkq;
    }
}
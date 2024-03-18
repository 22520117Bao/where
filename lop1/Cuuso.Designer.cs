namespace lop1
{
    partial class Cuuso
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
            this.btf1 = new System.Windows.Forms.Button();
            this.btf2 = new System.Windows.Forms.Button();
            this.btf3 = new System.Windows.Forms.Button();
            this.btf4 = new System.Windows.Forms.Button();
            this.btf5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btf1
            // 
            this.btf1.Location = new System.Drawing.Point(111, 50);
            this.btf1.Name = "btf1";
            this.btf1.Size = new System.Drawing.Size(110, 36);
            this.btf1.TabIndex = 0;
            this.btf1.Text = "form1";
            this.btf1.UseVisualStyleBackColor = true;
            this.btf1.Click += new System.EventHandler(this.btf1_Click);
            // 
            // btf2
            // 
            this.btf2.Location = new System.Drawing.Point(496, 50);
            this.btf2.Name = "btf2";
            this.btf2.Size = new System.Drawing.Size(110, 36);
            this.btf2.TabIndex = 1;
            this.btf2.Text = "form2";
            this.btf2.UseVisualStyleBackColor = true;
            this.btf2.Click += new System.EventHandler(this.btf2_Click);
            // 
            // btf3
            // 
            this.btf3.Location = new System.Drawing.Point(111, 160);
            this.btf3.Name = "btf3";
            this.btf3.Size = new System.Drawing.Size(110, 27);
            this.btf3.TabIndex = 2;
            this.btf3.Text = "form3";
            this.btf3.UseVisualStyleBackColor = true;
            this.btf3.Click += new System.EventHandler(this.btf3_Click);
            // 
            // btf4
            // 
            this.btf4.Location = new System.Drawing.Point(496, 160);
            this.btf4.Name = "btf4";
            this.btf4.Size = new System.Drawing.Size(110, 27);
            this.btf4.TabIndex = 3;
            this.btf4.Text = "form4";
            this.btf4.UseVisualStyleBackColor = true;
            this.btf4.Click += new System.EventHandler(this.btf4_Click);
            // 
            // btf5
            // 
            this.btf5.Location = new System.Drawing.Point(321, 239);
            this.btf5.Name = "btf5";
            this.btf5.Size = new System.Drawing.Size(90, 36);
            this.btf5.TabIndex = 4;
            this.btf5.Text = "form5";
            this.btf5.UseVisualStyleBackColor = true;
            this.btf5.Click += new System.EventHandler(this.btf5_Click);
            // 
            // Cuuso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btf5);
            this.Controls.Add(this.btf4);
            this.Controls.Add(this.btf3);
            this.Controls.Add(this.btf2);
            this.Controls.Add(this.btf1);
            this.Name = "Cuuso";
            this.Text = "Cuuso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btf1;
        private System.Windows.Forms.Button btf2;
        private System.Windows.Forms.Button btf3;
        private System.Windows.Forms.Button btf4;
        private System.Windows.Forms.Button btf5;
    }
}
namespace Semana07
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
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.tbS1 = new System.Windows.Forms.TextBox();
            this.tbS2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbM1
            // 
            this.tbM1.Location = new System.Drawing.Point(158, 61);
            this.tbM1.Name = "tbM1";
            this.tbM1.Size = new System.Drawing.Size(100, 20);
            this.tbM1.TabIndex = 0;
            // 
            // tbM2
            // 
            this.tbM2.Location = new System.Drawing.Point(158, 112);
            this.tbM2.Name = "tbM2";
            this.tbM2.Size = new System.Drawing.Size(100, 20);
            this.tbM2.TabIndex = 1;
            // 
            // tbS1
            // 
            this.tbS1.Location = new System.Drawing.Point(158, 206);
            this.tbS1.Name = "tbS1";
            this.tbS1.ReadOnly = true;
            this.tbS1.Size = new System.Drawing.Size(100, 20);
            this.tbS1.TabIndex = 2;
            this.tbS1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbS2
            // 
            this.tbS2.Location = new System.Drawing.Point(158, 244);
            this.tbS2.Name = "tbS2";
            this.tbS2.ReadOnly = true;
            this.tbS2.Size = new System.Drawing.Size(100, 20);
            this.tbS2.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(158, 157);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "M1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "M2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "S1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "S2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 319);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbS2);
            this.Controls.Add(this.tbS1);
            this.Controls.Add(this.tbM2);
            this.Controls.Add(this.tbM1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbM1;
        private System.Windows.Forms.TextBox tbM2;
        private System.Windows.Forms.TextBox tbS1;
        private System.Windows.Forms.TextBox tbS2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


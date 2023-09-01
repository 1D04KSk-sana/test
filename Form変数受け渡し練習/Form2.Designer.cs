
namespace Form変数受け渡し練習
{
    partial class Form2
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
            this.form2button1 = new System.Windows.Forms.Button();
            this.form2button2 = new System.Windows.Forms.Button();
            this.form2button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form2button1
            // 
            this.form2button1.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.form2button1.Location = new System.Drawing.Point(12, 12);
            this.form2button1.Name = "form2button1";
            this.form2button1.Size = new System.Drawing.Size(282, 92);
            this.form2button1.TabIndex = 1;
            this.form2button1.Text = "button1";
            this.form2button1.UseVisualStyleBackColor = true;
            this.form2button1.Click += new System.EventHandler(this.form2button1_Click);
            // 
            // form2button2
            // 
            this.form2button2.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.form2button2.Location = new System.Drawing.Point(12, 110);
            this.form2button2.Name = "form2button2";
            this.form2button2.Size = new System.Drawing.Size(282, 92);
            this.form2button2.TabIndex = 2;
            this.form2button2.Text = "button2";
            this.form2button2.UseVisualStyleBackColor = true;
            this.form2button2.Click += new System.EventHandler(this.form2button2_Click);
            // 
            // form2button3
            // 
            this.form2button3.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.form2button3.Location = new System.Drawing.Point(12, 208);
            this.form2button3.Name = "form2button3";
            this.form2button3.Size = new System.Drawing.Size(282, 92);
            this.form2button3.TabIndex = 3;
            this.form2button3.Text = "button3";
            this.form2button3.UseVisualStyleBackColor = true;
            this.form2button3.Click += new System.EventHandler(this.form2button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.label1.Location = new System.Drawing.Point(13, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form2button3);
            this.Controls.Add(this.form2button2);
            this.Controls.Add(this.form2button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form2button1;
        private System.Windows.Forms.Button form2button2;
        private System.Windows.Forms.Button form2button3;
        private System.Windows.Forms.Label label1;
    }
}
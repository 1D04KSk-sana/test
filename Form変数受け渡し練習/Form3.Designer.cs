
namespace Form変数受け渡し練習
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
            this.form3button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form3button1
            // 
            this.form3button1.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.form3button1.Location = new System.Drawing.Point(12, 12);
            this.form3button1.Name = "form3button1";
            this.form3button1.Size = new System.Drawing.Size(282, 92);
            this.form3button1.TabIndex = 2;
            this.form3button1.Text = "button1";
            this.form3button1.UseVisualStyleBackColor = true;
            this.form3button1.Click += new System.EventHandler(this.form3button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form3button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form3button1;
        private System.Windows.Forms.Label label1;
    }
}
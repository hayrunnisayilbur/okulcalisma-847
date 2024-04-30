namespace okulcalisma_847
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
            this.btnOgrenciEkleFrom = new System.Windows.Forms.Button();
            this.btnOgrenciListeleFrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciEkleFrom
            // 
            this.btnOgrenciEkleFrom.Location = new System.Drawing.Point(121, 40);
            this.btnOgrenciEkleFrom.Name = "btnOgrenciEkleFrom";
            this.btnOgrenciEkleFrom.Size = new System.Drawing.Size(149, 121);
            this.btnOgrenciEkleFrom.TabIndex = 0;
            this.btnOgrenciEkleFrom.Text = "öğrenci ekle";
            this.btnOgrenciEkleFrom.UseVisualStyleBackColor = true;
            this.btnOgrenciEkleFrom.Click += new System.EventHandler(this.btnOgrenciEkleFrom_Click);
            // 
            // btnOgrenciListeleFrom
            // 
            this.btnOgrenciListeleFrom.Location = new System.Drawing.Point(121, 195);
            this.btnOgrenciListeleFrom.Name = "btnOgrenciListeleFrom";
            this.btnOgrenciListeleFrom.Size = new System.Drawing.Size(149, 121);
            this.btnOgrenciListeleFrom.TabIndex = 1;
            this.btnOgrenciListeleFrom.Text = "tüm öğrenciler";
            this.btnOgrenciListeleFrom.UseVisualStyleBackColor = true;
            this.btnOgrenciListeleFrom.Click += new System.EventHandler(this.btnOgrenciListeleFrom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 396);
            this.Controls.Add(this.btnOgrenciListeleFrom);
            this.Controls.Add(this.btnOgrenciEkleFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkleFrom;
        private System.Windows.Forms.Button btnOgrenciListeleFrom;
    }
}


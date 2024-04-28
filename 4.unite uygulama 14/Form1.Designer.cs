namespace _4.unite_uygulama_14
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
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.btnSiraCikar = new System.Windows.Forms.Button();
            this.listeSiralar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Location = new System.Drawing.Point(23, 12);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(192, 149);
            this.btnSiraAl.TabIndex = 0;
            this.btnSiraAl.Text = "sira al";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click);
            // 
            // btnSiraCikar
            // 
            this.btnSiraCikar.Location = new System.Drawing.Point(461, 12);
            this.btnSiraCikar.Name = "btnSiraCikar";
            this.btnSiraCikar.Size = new System.Drawing.Size(192, 149);
            this.btnSiraCikar.TabIndex = 1;
            this.btnSiraCikar.Text = "sira çıkar";
            this.btnSiraCikar.UseVisualStyleBackColor = true;
            this.btnSiraCikar.Click += new System.EventHandler(this.btnSiraCikar_Click);
            // 
            // listeSiralar
            // 
            this.listeSiralar.FormattingEnabled = true;
            this.listeSiralar.Location = new System.Drawing.Point(259, 12);
            this.listeSiralar.Name = "listeSiralar";
            this.listeSiralar.Size = new System.Drawing.Size(183, 381);
            this.listeSiralar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeSiralar);
            this.Controls.Add(this.btnSiraCikar);
            this.Controls.Add(this.btnSiraAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiraAl;
        private System.Windows.Forms.Button btnSiraCikar;
        private System.Windows.Forms.ListBox listeSiralar;
    }
}


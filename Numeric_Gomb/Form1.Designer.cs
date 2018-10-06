namespace Numeric_Gomb
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
            this.Sor_Szam = new System.Windows.Forms.NumericUpDown();
            this.Sor_Szeret = new System.Windows.Forms.Label();
            this.Hozzaad = new System.Windows.Forms.Button();
            this.Ha_Ez_Mindent_Kiir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sor_Szam)).BeginInit();
            this.SuspendLayout();
            // 
            // Sor_Szam
            // 
            this.Sor_Szam.Location = new System.Drawing.Point(124, 13);
            this.Sor_Szam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sor_Szam.Name = "Sor_Szam";
            this.Sor_Szam.Size = new System.Drawing.Size(37, 20);
            this.Sor_Szam.TabIndex = 0;
            this.Sor_Szam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Sor_Szeret
            // 
            this.Sor_Szeret.AutoSize = true;
            this.Sor_Szeret.Location = new System.Drawing.Point(13, 13);
            this.Sor_Szeret.Name = "Sor_Szeret";
            this.Sor_Szeret.Size = new System.Drawing.Size(105, 13);
            this.Sor_Szeret.TabIndex = 1;
            this.Sor_Szeret.Text = "Ennyi sort szeretnék:";
            // 
            // Hozzaad
            // 
            this.Hozzaad.Location = new System.Drawing.Point(167, 8);
            this.Hozzaad.Name = "Hozzaad";
            this.Hozzaad.Size = new System.Drawing.Size(75, 23);
            this.Hozzaad.TabIndex = 2;
            this.Hozzaad.Text = "Hozzaad";
            this.Hozzaad.UseVisualStyleBackColor = true;
            this.Hozzaad.Click += new System.EventHandler(this.Hozzaadas);
            // 
            // Ha_Ez_Mindent_Kiir
            // 
            this.Ha_Ez_Mindent_Kiir.Location = new System.Drawing.Point(249, 9);
            this.Ha_Ez_Mindent_Kiir.Name = "Ha_Ez_Mindent_Kiir";
            this.Ha_Ez_Mindent_Kiir.Size = new System.Drawing.Size(108, 23);
            this.Ha_Ez_Mindent_Kiir.TabIndex = 3;
            this.Ha_Ez_Mindent_Kiir.Text = "Naon minden kiíííír";
            this.Ha_Ez_Mindent_Kiir.UseVisualStyleBackColor = true;
            this.Ha_Ez_Mindent_Kiir.Click += new System.EventHandler(this.Ha_Ez_Mindent_Kiir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 345);
            this.Controls.Add(this.Ha_Ez_Mindent_Kiir);
            this.Controls.Add(this.Hozzaad);
            this.Controls.Add(this.Sor_Szeret);
            this.Controls.Add(this.Sor_Szam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Sor_Szam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Sor_Szam;
        private System.Windows.Forms.Label Sor_Szeret;
        private System.Windows.Forms.Button Hozzaad;
        private System.Windows.Forms.Button Ha_Ez_Mindent_Kiir;
    }
}


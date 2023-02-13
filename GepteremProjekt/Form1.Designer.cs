namespace GepteremProject
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
            this.button_Balra = new System.Windows.Forms.Button();
            this.picturebox_kep = new System.Windows.Forms.PictureBox();
            this.button_Jobbra = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_kep)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Balra
            // 
            this.button_Balra.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Balra.Location = new System.Drawing.Point(12, 118);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(77, 54);
            this.button_Balra.TabIndex = 0;
            this.button_Balra.UseVisualStyleBackColor = true;
            this.button_Balra.Click += new System.EventHandler(this.button_Balra_Click);
            // 
            // picturebox_kep
            // 
            this.picturebox_kep.Location = new System.Drawing.Point(95, 75);
            this.picturebox_kep.Name = "picturebox_kep";
            this.picturebox_kep.Size = new System.Drawing.Size(100, 140);
            this.picturebox_kep.TabIndex = 1;
            this.picturebox_kep.TabStop = false;
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Jobbra.Location = new System.Drawing.Point(201, 118);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(75, 54);
            this.button_Jobbra.TabIndex = 2;
            this.button_Jobbra.UseVisualStyleBackColor = true;
            this.button_Jobbra.Click += new System.EventHandler(this.button_Jobbra_Click);
            // 
            // button_Mentes
            // 
            this.button_Mentes.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.button_Mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Mentes.Location = new System.Drawing.Point(95, 233);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(100, 72);
            this.button_Mentes.TabIndex = 3;
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(330, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 176);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.picturebox_kep);
            this.Controls.Add(this.button_Balra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_kep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.PictureBox picturebox_kep;
        private System.Windows.Forms.Button button_Jobbra;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Panel panel1;
    }
}


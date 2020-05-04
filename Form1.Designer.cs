namespace GepteremProjekt {
    partial class GepteremProjekt {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.kep = new System.Windows.Forms.PictureBox();
            this.kovetkezo = new System.Windows.Forms.PictureBox();
            this.mentes = new System.Windows.Forms.PictureBox();
            this.elozo = new System.Windows.Forms.PictureBox();
            this.gombok = new System.Windows.Forms.Panel();
            this.keszitette = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kovetkezo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elozo)).BeginInit();
            this.SuspendLayout();
            // 
            // kep
            // 
            this.kep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kep.Location = new System.Drawing.Point(53, 12);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(100, 150);
            this.kep.TabIndex = 1;
            this.kep.TabStop = false;
            // 
            // kovetkezo
            // 
            this.kovetkezo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kovetkezo.Location = new System.Drawing.Point(159, 67);
            this.kovetkezo.Name = "kovetkezo";
            this.kovetkezo.Size = new System.Drawing.Size(40, 40);
            this.kovetkezo.TabIndex = 2;
            this.kovetkezo.TabStop = false;
            // 
            // mentes
            // 
            this.mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mentes.Location = new System.Drawing.Point(78, 168);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(50, 50);
            this.mentes.TabIndex = 3;
            this.mentes.TabStop = false;
            // 
            // elozo
            // 
            this.elozo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.elozo.Location = new System.Drawing.Point(7, 67);
            this.elozo.Name = "elozo";
            this.elozo.Size = new System.Drawing.Size(40, 40);
            this.elozo.TabIndex = 4;
            this.elozo.TabStop = false;
            // 
            // gombok
            // 
            this.gombok.Location = new System.Drawing.Point(215, 12);
            this.gombok.Name = "gombok";
            this.gombok.Size = new System.Drawing.Size(420, 252);
            this.gombok.TabIndex = 5;
            // 
            // keszitette
            // 
            this.keszitette.AutoSize = true;
            this.keszitette.Location = new System.Drawing.Point(4, 253);
            this.keszitette.Name = "keszitette";
            this.keszitette.Size = new System.Drawing.Size(95, 13);
            this.keszitette.TabIndex = 6;
            this.keszitette.Text = "Nagy Norbert 14.S";
            // 
            // GepteremProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 275);
            this.Controls.Add(this.keszitette);
            this.Controls.Add(this.gombok);
            this.Controls.Add(this.elozo);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.kovetkezo);
            this.Controls.Add(this.kep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GepteremProjekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Géptermek";
            ((System.ComponentModel.ISupportInitialize)(this.kep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kovetkezo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elozo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox kep;
        private System.Windows.Forms.PictureBox kovetkezo;
        private System.Windows.Forms.PictureBox mentes;
        private System.Windows.Forms.PictureBox elozo;
        private System.Windows.Forms.Panel gombok;
        private System.Windows.Forms.Label keszitette;
    }
}


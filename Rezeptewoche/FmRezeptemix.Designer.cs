namespace Rezeptewoche
{
    partial class FmRezeptemix
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
            this.btZurueck = new System.Windows.Forms.Button();
            this.btWocheGenerieren = new System.Windows.Forms.Button();
            this.lbDienstag = new System.Windows.Forms.Label();
            this.gbMix = new System.Windows.Forms.GroupBox();
            this.lbSonntag = new System.Windows.Forms.Label();
            this.lbSamstag = new System.Windows.Forms.Label();
            this.lbFreitag = new System.Windows.Forms.Label();
            this.lbDonnerstag = new System.Windows.Forms.Label();
            this.lbMittwoch = new System.Windows.Forms.Label();
            this.lbMontag = new System.Windows.Forms.Label();
            this.gbMix.SuspendLayout();
            this.SuspendLayout();
            // 
            // btZurueck
            // 
            this.btZurueck.Location = new System.Drawing.Point(89, 370);
            this.btZurueck.Name = "btZurueck";
            this.btZurueck.Size = new System.Drawing.Size(75, 23);
            this.btZurueck.TabIndex = 0;
            this.btZurueck.Text = "Zurück";
            this.btZurueck.UseVisualStyleBackColor = true;
            this.btZurueck.Click += new System.EventHandler(this.btZurueck_Click);
            // 
            // btWocheGenerieren
            // 
            this.btWocheGenerieren.Location = new System.Drawing.Point(89, 99);
            this.btWocheGenerieren.Name = "btWocheGenerieren";
            this.btWocheGenerieren.Size = new System.Drawing.Size(342, 23);
            this.btWocheGenerieren.TabIndex = 1;
            this.btWocheGenerieren.Text = "Woche generieren";
            this.btWocheGenerieren.UseVisualStyleBackColor = true;
            this.btWocheGenerieren.Click += new System.EventHandler(this.btWocheGenerieren_Click);
            // 
            // lbDienstag
            // 
            this.lbDienstag.AutoSize = true;
            this.lbDienstag.Location = new System.Drawing.Point(13, 47);
            this.lbDienstag.Name = "lbDienstag";
            this.lbDienstag.Size = new System.Drawing.Size(35, 13);
            this.lbDienstag.TabIndex = 3;
            this.lbDienstag.Text = "label2";
            // 
            // gbMix
            // 
            this.gbMix.Controls.Add(this.lbSonntag);
            this.gbMix.Controls.Add(this.lbSamstag);
            this.gbMix.Controls.Add(this.lbFreitag);
            this.gbMix.Controls.Add(this.lbDonnerstag);
            this.gbMix.Controls.Add(this.lbMittwoch);
            this.gbMix.Controls.Add(this.lbMontag);
            this.gbMix.Controls.Add(this.lbDienstag);
            this.gbMix.Location = new System.Drawing.Point(89, 161);
            this.gbMix.Name = "gbMix";
            this.gbMix.Size = new System.Drawing.Size(436, 185);
            this.gbMix.TabIndex = 4;
            this.gbMix.TabStop = false;
            this.gbMix.Text = "Rezepte der Woche";
            // 
            // lbSonntag
            // 
            this.lbSonntag.AutoSize = true;
            this.lbSonntag.Location = new System.Drawing.Point(13, 158);
            this.lbSonntag.Name = "lbSonntag";
            this.lbSonntag.Size = new System.Drawing.Size(35, 13);
            this.lbSonntag.TabIndex = 8;
            this.lbSonntag.Text = "label2";
            // 
            // lbSamstag
            // 
            this.lbSamstag.AutoSize = true;
            this.lbSamstag.Location = new System.Drawing.Point(13, 136);
            this.lbSamstag.Name = "lbSamstag";
            this.lbSamstag.Size = new System.Drawing.Size(35, 13);
            this.lbSamstag.TabIndex = 7;
            this.lbSamstag.Text = "label1";
            // 
            // lbFreitag
            // 
            this.lbFreitag.AutoSize = true;
            this.lbFreitag.Location = new System.Drawing.Point(13, 114);
            this.lbFreitag.Name = "lbFreitag";
            this.lbFreitag.Size = new System.Drawing.Size(35, 13);
            this.lbFreitag.TabIndex = 6;
            this.lbFreitag.Text = "label5";
            // 
            // lbDonnerstag
            // 
            this.lbDonnerstag.AutoSize = true;
            this.lbDonnerstag.Location = new System.Drawing.Point(13, 92);
            this.lbDonnerstag.Name = "lbDonnerstag";
            this.lbDonnerstag.Size = new System.Drawing.Size(35, 13);
            this.lbDonnerstag.TabIndex = 5;
            this.lbDonnerstag.Text = "label4";
            // 
            // lbMittwoch
            // 
            this.lbMittwoch.AutoSize = true;
            this.lbMittwoch.Location = new System.Drawing.Point(13, 69);
            this.lbMittwoch.Name = "lbMittwoch";
            this.lbMittwoch.Size = new System.Drawing.Size(35, 13);
            this.lbMittwoch.TabIndex = 4;
            this.lbMittwoch.Text = "label3";
            // 
            // lbMontag
            // 
            this.lbMontag.AutoSize = true;
            this.lbMontag.Location = new System.Drawing.Point(13, 25);
            this.lbMontag.Name = "lbMontag";
            this.lbMontag.Size = new System.Drawing.Size(35, 13);
            this.lbMontag.TabIndex = 3;
            this.lbMontag.Text = "label1";
            // 
            // FmRezeptemix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMix);
            this.Controls.Add(this.btWocheGenerieren);
            this.Controls.Add(this.btZurueck);
            this.Name = "FmRezeptemix";
            this.Text = "FmRezeptemix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmRezeptemix_FormClosed);
            this.gbMix.ResumeLayout(false);
            this.gbMix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btZurueck;
        private System.Windows.Forms.Button btWocheGenerieren;
        private System.Windows.Forms.Label lbDienstag;
        private System.Windows.Forms.GroupBox gbMix;
        private System.Windows.Forms.Label lbSonntag;
        private System.Windows.Forms.Label lbSamstag;
        private System.Windows.Forms.Label lbFreitag;
        private System.Windows.Forms.Label lbDonnerstag;
        private System.Windows.Forms.Label lbMittwoch;
        private System.Windows.Forms.Label lbMontag;
    }
}
namespace LP_LBlom_S21M
{
    partial class Hoofdscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoofdscherm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewVisit = new System.Windows.Forms.Button();
            this.btnNewProj = new System.Windows.Forms.Button();
            this.btnExportXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteer project";
            // 
            // btnNewVisit
            // 
            this.btnNewVisit.Location = new System.Drawing.Point(388, 48);
            this.btnNewVisit.Name = "btnNewVisit";
            this.btnNewVisit.Size = new System.Drawing.Size(75, 42);
            this.btnNewVisit.TabIndex = 5;
            this.btnNewVisit.Text = "Nieuw bezoek";
            this.btnNewVisit.Click += new System.EventHandler(this.btnNewVisit_Click);
            // 
            // btnNewProj
            // 
            this.btnNewProj.Enabled = false;
            this.btnNewProj.Location = new System.Drawing.Point(142, 15);
            this.btnNewProj.Name = "btnNewProj";
            this.btnNewProj.Size = new System.Drawing.Size(75, 39);
            this.btnNewProj.TabIndex = 4;
            this.btnNewProj.Text = "Nieuw project";
            this.btnNewProj.UseVisualStyleBackColor = true;
            // 
            // btnExportXML
            // 
            this.btnExportXML.Location = new System.Drawing.Point(142, 60);
            this.btnExportXML.Name = "btnExportXML";
            this.btnExportXML.Size = new System.Drawing.Size(75, 42);
            this.btnExportXML.TabIndex = 6;
            this.btnExportXML.Text = "Gegevens exporteren";
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 141);
            this.Controls.Add(this.btnExportXML);
            this.Controls.Add(this.btnNewProj);
            this.Controls.Add(this.btnNewVisit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Hoofdscherm";
            this.Text = "Hoofdscherm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewVisit;
        private System.Windows.Forms.Button btnNewProj;
        private System.Windows.Forms.Button btnExportXML;
    }
}


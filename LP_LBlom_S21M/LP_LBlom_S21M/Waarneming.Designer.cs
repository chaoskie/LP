namespace LP_LBlom_S21M
{
    partial class Waarneming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waarneming));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbVogelSoortenZoeken = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoekVogelMarkering = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVogelsoort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVA = new System.Windows.Forms.Button();
            this.btnTI = new System.Windows.Forms.Button();
            this.btnNI = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbVogelSoortenZoeken,
            this.btnZoekVogelMarkering});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(932, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem,
            this.exporterenToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            // 
            // exporterenToolStripMenuItem
            // 
            this.exporterenToolStripMenuItem.Name = "exporterenToolStripMenuItem";
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exporterenToolStripMenuItem.Text = "Exporteren";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 511);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Zoeken ";
            // 
            // cbVogelSoortenZoeken
            // 
            this.cbVogelSoortenZoeken.Name = "cbVogelSoortenZoeken";
            this.cbVogelSoortenZoeken.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnZoekVogelMarkering
            // 
            this.btnZoekVogelMarkering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnZoekVogelMarkering.Image = ((System.Drawing.Image)(resources.GetObject("btnZoekVogelMarkering.Image")));
            this.btnZoekVogelMarkering.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoekVogelMarkering.Name = "btnZoekVogelMarkering";
            this.btnZoekVogelMarkering.Size = new System.Drawing.Size(40, 22);
            this.btnZoekVogelMarkering.Text = "Zoek!";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNI);
            this.groupBox1.Controls.Add(this.btnTI);
            this.groupBox1.Controls.Add(this.btnVA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbVogelsoort);
            this.groupBox1.Location = new System.Drawing.Point(704, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Markeringen";
            // 
            // cbVogelsoort
            // 
            this.cbVogelsoort.FormattingEnabled = true;
            this.cbVogelsoort.Location = new System.Drawing.Point(60, 53);
            this.cbVogelsoort.Name = "cbVogelsoort";
            this.cbVogelsoort.Size = new System.Drawing.Size(138, 21);
            this.cbVogelsoort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vogelsoorten:";
            // 
            // btnVA
            // 
            this.btnVA.Location = new System.Drawing.Point(125, 116);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(75, 23);
            this.btnVA.TabIndex = 2;
            this.btnVA.Text = "VA";
            this.btnVA.UseVisualStyleBackColor = true;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // btnTI
            // 
            this.btnTI.Location = new System.Drawing.Point(125, 145);
            this.btnTI.Name = "btnTI";
            this.btnTI.Size = new System.Drawing.Size(75, 23);
            this.btnTI.TabIndex = 3;
            this.btnTI.Text = "TI";
            this.btnTI.UseVisualStyleBackColor = true;
            this.btnTI.Click += new System.EventHandler(this.btnTI_Click);
            // 
            // btnNI
            // 
            this.btnNI.Location = new System.Drawing.Point(125, 174);
            this.btnNI.Name = "btnNI";
            this.btnNI.Size = new System.Drawing.Size(75, 23);
            this.btnNI.TabIndex = 4;
            this.btnNI.Text = "NI";
            this.btnNI.UseVisualStyleBackColor = true;
            this.btnNI.Click += new System.EventHandler(this.btnNI_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vogel Aanwezig";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Territorium Indicerend";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nest Indicerend";
            // 
            // Waarneming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Waarneming";
            this.Text = "Waarnemingen";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterenToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbVogelSoortenZoeken;
        private System.Windows.Forms.ToolStripButton btnZoekVogelMarkering;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNI;
        private System.Windows.Forms.Button btnTI;
        private System.Windows.Forms.Button btnVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVogelsoort;
    }
}
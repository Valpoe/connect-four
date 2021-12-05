namespace Lopputyo
{
    partial class FrmLopputyo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLopputyo));
            this.panel0 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ss1 = new System.Windows.Forms.StatusStrip();
            this.tsslKulunutPeliAika = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslKummanVuoro = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslViimeisinSiirto = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiValikko = new System.Windows.Forms.ToolStripMenuItem();
            this.aloitaPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vieTiedostoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sfdTiedot1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.avaaPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel0.SuspendLayout();
            this.ss1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel0
            // 
            this.panel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel0.Controls.Add(this.button2);
            this.panel0.Controls.Add(this.button1);
            this.panel0.Controls.Add(this.label9);
            this.panel0.Controls.Add(this.label8);
            this.panel0.Controls.Add(this.label7);
            this.panel0.Controls.Add(this.label6);
            this.panel0.Controls.Add(this.label4);
            this.panel0.Controls.Add(this.label2);
            this.panel0.Controls.Add(this.lbl1);
            this.panel0.Controls.Add(this.panel1);
            this.panel0.Controls.Add(this.ss1);
            this.panel0.Controls.Add(this.menuStrip1);
            this.panel0.Location = new System.Drawing.Point(12, 12);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(565, 596);
            this.panel0.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Aloita Peli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAloitaPeli_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(43, 67);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(14, 16);
            this.lbl1.TabIndex = 22;
            this.lbl1.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 474);
            this.panel1.TabIndex = 21;
            // 
            // ss1
            // 
            this.ss1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ss1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslKulunutPeliAika,
            this.tsslKummanVuoro,
            this.tsslViimeisinSiirto});
            this.ss1.Location = new System.Drawing.Point(0, 572);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(563, 22);
            this.ss1.TabIndex = 19;
            this.ss1.Text = "statusStrip1";
            // 
            // tsslKulunutPeliAika
            // 
            this.tsslKulunutPeliAika.Enabled = false;
            this.tsslKulunutPeliAika.Name = "tsslKulunutPeliAika";
            this.tsslKulunutPeliAika.Size = new System.Drawing.Size(33, 17);
            this.tsslKulunutPeliAika.Text = "Aika:";
            // 
            // tsslKummanVuoro
            // 
            this.tsslKummanVuoro.Enabled = false;
            this.tsslKummanVuoro.Name = "tsslKummanVuoro";
            this.tsslKummanVuoro.Size = new System.Drawing.Size(42, 17);
            this.tsslKummanVuoro.Text = "Vuoro:";
            // 
            // tsslViimeisinSiirto
            // 
            this.tsslViimeisinSiirto.Enabled = false;
            this.tsslViimeisinSiirto.Name = "tsslViimeisinSiirto";
            this.tsslViimeisinSiirto.Size = new System.Drawing.Size(87, 17);
            this.tsslViimeisinSiirto.Text = "Viimeisin siirto:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiValikko});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiValikko
            // 
            this.tsmiValikko.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aloitaPeliToolStripMenuItem,
            this.avaaPeliToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.vieTiedostoonToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tsmiValikko.Name = "tsmiValikko";
            this.tsmiValikko.Size = new System.Drawing.Size(56, 22);
            this.tsmiValikko.Text = "Valikko";
            // 
            // aloitaPeliToolStripMenuItem
            // 
            this.aloitaPeliToolStripMenuItem.Name = "aloitaPeliToolStripMenuItem";
            this.aloitaPeliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aloitaPeliToolStripMenuItem.Text = "Aloita peli";
            this.aloitaPeliToolStripMenuItem.Click += new System.EventHandler(this.btnAloitaPeli_Click);
            // 
            // vieTiedostoonToolStripMenuItem
            // 
            this.vieTiedostoonToolStripMenuItem.Enabled = false;
            this.vieTiedostoonToolStripMenuItem.Name = "vieTiedostoonToolStripMenuItem";
            this.vieTiedostoonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vieTiedostoonToolStripMenuItem.Text = "Tallenna tulos";
            this.vieTiedostoonToolStripMenuItem.Click += new System.EventHandler(this.vieTiedostoonToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Enabled = false;
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna peli";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // avaaPeliToolStripMenuItem
            // 
            this.avaaPeliToolStripMenuItem.Enabled = false;
            this.avaaPeliToolStripMenuItem.Name = "avaaPeliToolStripMenuItem";
            this.avaaPeliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avaaPeliToolStripMenuItem.Text = "Avaa Peli";
            // 
            // FrmLopputyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 620);
            this.Controls.Add(this.panel0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLopputyo";
            this.Text = "Neljän suora";
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.ss1.ResumeLayout(false);
            this.ss1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiValikko;
        private System.Windows.Forms.ToolStripMenuItem aloitaPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ss1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog sfdTiedot1;
        public System.Windows.Forms.ToolStripStatusLabel tsslKummanVuoro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.ToolStripStatusLabel tsslKulunutPeliAika;
        public System.Windows.Forms.ToolStripStatusLabel tsslViimeisinSiirto;
        public System.Windows.Forms.ToolStripMenuItem vieTiedostoonToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem avaaPeliToolStripMenuItem;
    }
}


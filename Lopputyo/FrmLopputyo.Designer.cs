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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panel0 = new System.Windows.Forms.Panel();
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
            this.btnAloitaPeli = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sfdTiedot1 = new System.Windows.Forms.SaveFileDialog();
            this.panel0.SuspendLayout();
            this.ss1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 69);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(90, 69);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(167, 69);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(244, 69);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(321, 69);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(398, 69);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(475, 69);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // panel0
            // 
            this.panel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel0.Controls.Add(this.panel1);
            this.panel0.Controls.Add(this.ss1);
            this.panel0.Controls.Add(this.menuStrip1);
            this.panel0.Controls.Add(this.btnAloitaPeli);
            this.panel0.Controls.Add(this.btn7);
            this.panel0.Controls.Add(this.btn6);
            this.panel0.Controls.Add(this.btn5);
            this.panel0.Controls.Add(this.btn4);
            this.panel0.Controls.Add(this.btn3);
            this.panel0.Controls.Add(this.btn2);
            this.panel0.Controls.Add(this.btn1);
            this.panel0.Location = new System.Drawing.Point(12, 12);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(565, 596);
            this.panel0.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 474);
            this.panel1.TabIndex = 21;
            this.panel1.BackColorChanged += new System.EventHandler(this.panel1_BackColorChanged);
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
            this.tsslKulunutPeliAika.Name = "tsslKulunutPeliAika";
            this.tsslKulunutPeliAika.Size = new System.Drawing.Size(33, 17);
            this.tsslKulunutPeliAika.Text = "Aika:";
            // 
            // tsslKummanVuoro
            // 
            this.tsslKummanVuoro.Name = "tsslKummanVuoro";
            this.tsslKummanVuoro.Size = new System.Drawing.Size(42, 17);
            this.tsslKummanVuoro.Text = "Vuoro:";
            // 
            // tsslViimeisinSiirto
            // 
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
            this.vieTiedostoonToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tsmiValikko.Name = "tsmiValikko";
            this.tsmiValikko.Size = new System.Drawing.Size(56, 22);
            this.tsmiValikko.Text = "Valikko";
            // 
            // aloitaPeliToolStripMenuItem
            // 
            this.aloitaPeliToolStripMenuItem.Name = "aloitaPeliToolStripMenuItem";
            this.aloitaPeliToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aloitaPeliToolStripMenuItem.Text = "Aloita peli";
            this.aloitaPeliToolStripMenuItem.Click += new System.EventHandler(this.btnAloitaPeli_Click);
            // 
            // vieTiedostoonToolStripMenuItem
            // 
            this.vieTiedostoonToolStripMenuItem.Name = "vieTiedostoonToolStripMenuItem";
            this.vieTiedostoonToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.vieTiedostoonToolStripMenuItem.Text = "Vie tiedostoon";
            this.vieTiedostoonToolStripMenuItem.Click += new System.EventHandler(this.vieTiedostoonToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // btnAloitaPeli
            // 
            this.btnAloitaPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAloitaPeli.Location = new System.Drawing.Point(232, 33);
            this.btnAloitaPeli.Name = "btnAloitaPeli";
            this.btnAloitaPeli.Size = new System.Drawing.Size(100, 30);
            this.btnAloitaPeli.TabIndex = 15;
            this.btnAloitaPeli.UseVisualStyleBackColor = true;
            this.btnAloitaPeli.Click += new System.EventHandler(this.btnAloitaPeli_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnAloitaPeli;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiValikko;
        private System.Windows.Forms.ToolStripMenuItem aloitaPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vieTiedostoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ss1;
        private System.Windows.Forms.ToolStripStatusLabel tsslKulunutPeliAika;
        private System.Windows.Forms.ToolStripStatusLabel tsslViimeisinSiirto;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog sfdTiedot1;
        public System.Windows.Forms.ToolStripStatusLabel tsslKummanVuoro;
    }
}


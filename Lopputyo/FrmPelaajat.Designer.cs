namespace Lopputyo
{
    partial class FrmPelaajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPelaajat));
            this.tbPelaaja1 = new System.Windows.Forms.TextBox();
            this.tbPelaaja2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPelaaja1
            // 
            this.tbPelaaja1.Location = new System.Drawing.Point(122, 34);
            this.tbPelaaja1.MaxLength = 20;
            this.tbPelaaja1.Name = "tbPelaaja1";
            this.tbPelaaja1.Size = new System.Drawing.Size(100, 20);
            this.tbPelaaja1.TabIndex = 0;
            this.tbPelaaja1.TextChanged += new System.EventHandler(this.tbPelaaja1_TextChanged);
            this.tbPelaaja1.Validating += new System.ComponentModel.CancelEventHandler(this.tbPelaaja1_Validating);
            // 
            // tbPelaaja2
            // 
            this.tbPelaaja2.Location = new System.Drawing.Point(122, 80);
            this.tbPelaaja2.MaxLength = 20;
            this.tbPelaaja2.Name = "tbPelaaja2";
            this.tbPelaaja2.Size = new System.Drawing.Size(100, 20);
            this.tbPelaaja2.TabIndex = 1;
            this.tbPelaaja2.TextChanged += new System.EventHandler(this.tbPelaaja2_TextChanged);
            this.tbPelaaja2.Validating += new System.ComponentModel.CancelEventHandler(this.tbPelaaja1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pelaaja 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pelaaja 2";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(122, 124);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lopputyo.Properties.Resources.PlayerYellow;
            this.pictureBox2.Location = new System.Drawing.Point(14, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lopputyo.Properties.Resources.PlayerRed;
            this.pictureBox1.Location = new System.Drawing.Point(14, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPelaajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 168);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPelaaja2);
            this.Controls.Add(this.tbPelaaja1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPelaajat";
            this.Text = "Pelaajat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox tbPelaaja1;
        public System.Windows.Forms.TextBox tbPelaaja2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
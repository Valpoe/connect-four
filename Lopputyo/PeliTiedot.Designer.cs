
namespace Lopputyo
{
    partial class PeliTiedot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeliTiedot));
            this.btnSuljePeliTiedot = new System.Windows.Forms.Button();
            this.rtbPelaajaTiedot = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSuljePeliTiedot
            // 
            this.btnSuljePeliTiedot.Location = new System.Drawing.Point(68, 404);
            this.btnSuljePeliTiedot.Name = "btnSuljePeliTiedot";
            this.btnSuljePeliTiedot.Size = new System.Drawing.Size(206, 68);
            this.btnSuljePeliTiedot.TabIndex = 0;
            this.btnSuljePeliTiedot.Text = "Sulje";
            this.btnSuljePeliTiedot.UseVisualStyleBackColor = true;
            this.btnSuljePeliTiedot.Click += new System.EventHandler(this.btnSuljePeliTiedot_Click);
            // 
            // rtbPelaajaTiedot
            // 
            this.rtbPelaajaTiedot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPelaajaTiedot.Location = new System.Drawing.Point(12, 12);
            this.rtbPelaajaTiedot.Name = "rtbPelaajaTiedot";
            this.rtbPelaajaTiedot.Size = new System.Drawing.Size(322, 378);
            this.rtbPelaajaTiedot.TabIndex = 1;
            this.rtbPelaajaTiedot.Text = "";
            // 
            // PeliTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 485);
            this.Controls.Add(this.rtbPelaajaTiedot);
            this.Controls.Add(this.btnSuljePeliTiedot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeliTiedot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pelitiedot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuljePeliTiedot;
        public System.Windows.Forms.RichTextBox rtbPelaajaTiedot;
    }
}
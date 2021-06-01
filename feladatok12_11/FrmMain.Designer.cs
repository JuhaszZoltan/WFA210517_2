
namespace feladatok12_11
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rtbDiakok = new System.Windows.Forms.RichTextBox();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPontszam = new System.Windows.Forms.TextBox();
            this.btnAtlagpontszam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(158, 24);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(161, 26);
            this.tbNev.TabIndex = 1;
            // 
            // rtbDiakok
            // 
            this.rtbDiakok.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbDiakok.Location = new System.Drawing.Point(31, 193);
            this.rtbDiakok.Name = "rtbDiakok";
            this.rtbDiakok.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDiakok.Size = new System.Drawing.Size(288, 176);
            this.rtbDiakok.TabIndex = 0;
            this.rtbDiakok.TabStop = false;
            this.rtbDiakok.Text = "";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(31, 131);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(288, 45);
            this.btnAdatbevitel.TabIndex = 3;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.BtnAdatbevitel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pontszám:";
            // 
            // tbPontszam
            // 
            this.tbPontszam.Location = new System.Drawing.Point(158, 77);
            this.tbPontszam.Name = "tbPontszam";
            this.tbPontszam.Size = new System.Drawing.Size(161, 26);
            this.tbPontszam.TabIndex = 2;
            // 
            // btnAtlagpontszam
            // 
            this.btnAtlagpontszam.Location = new System.Drawing.Point(31, 390);
            this.btnAtlagpontszam.Name = "btnAtlagpontszam";
            this.btnAtlagpontszam.Size = new System.Drawing.Size(288, 46);
            this.btnAtlagpontszam.TabIndex = 0;
            this.btnAtlagpontszam.TabStop = false;
            this.btnAtlagpontszam.Text = "Átlagpontszám";
            this.btnAtlagpontszam.UseVisualStyleBackColor = true;
            this.btnAtlagpontszam.Click += new System.EventHandler(this.btnAtlagpontszam_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 462);
            this.Controls.Add(this.btnAtlagpontszam);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.rtbDiakok);
            this.Controls.Add(this.tbPontszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Dolgozatok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.RichTextBox rtbDiakok;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPontszam;
        private System.Windows.Forms.Button btnAtlagpontszam;
    }
}


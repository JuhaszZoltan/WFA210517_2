
namespace feladatok12_6
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
            this.tbAlso = new System.Windows.Forms.TextBox();
            this.lblAlso = new System.Windows.Forms.Label();
            this.btnMegallapit = new System.Windows.Forms.Button();
            this.lblFelso = new System.Windows.Forms.Label();
            this.lblMegadottSzam = new System.Windows.Forms.Label();
            this.tbFelso = new System.Windows.Forms.TextBox();
            this.tbSzam = new System.Windows.Forms.TextBox();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAlso
            // 
            this.tbAlso.Location = new System.Drawing.Point(31, 60);
            this.tbAlso.Name = "tbAlso";
            this.tbAlso.Size = new System.Drawing.Size(100, 26);
            this.tbAlso.TabIndex = 0;
            // 
            // lblAlso
            // 
            this.lblAlso.AutoSize = true;
            this.lblAlso.Location = new System.Drawing.Point(27, 37);
            this.lblAlso.Name = "lblAlso";
            this.lblAlso.Size = new System.Drawing.Size(88, 20);
            this.lblAlso.TabIndex = 1;
            this.lblAlso.Text = "alsó határ:";
            // 
            // btnMegallapit
            // 
            this.btnMegallapit.Location = new System.Drawing.Point(181, 123);
            this.btnMegallapit.Name = "btnMegallapit";
            this.btnMegallapit.Size = new System.Drawing.Size(166, 49);
            this.btnMegallapit.TabIndex = 2;
            this.btnMegallapit.Text = "megállapít";
            this.btnMegallapit.UseVisualStyleBackColor = true;
            this.btnMegallapit.Click += new System.EventHandler(this.BtnMegallapit_Click);
            // 
            // lblFelso
            // 
            this.lblFelso.AutoSize = true;
            this.lblFelso.Location = new System.Drawing.Point(243, 37);
            this.lblFelso.Name = "lblFelso";
            this.lblFelso.Size = new System.Drawing.Size(93, 20);
            this.lblFelso.TabIndex = 1;
            this.lblFelso.Text = "felső határ:";
            // 
            // lblMegadottSzam
            // 
            this.lblMegadottSzam.AutoSize = true;
            this.lblMegadottSzam.Location = new System.Drawing.Point(27, 123);
            this.lblMegadottSzam.Name = "lblMegadottSzam";
            this.lblMegadottSzam.Size = new System.Drawing.Size(129, 20);
            this.lblMegadottSzam.TabIndex = 1;
            this.lblMegadottSzam.Text = "megadott szám:";
            // 
            // tbFelso
            // 
            this.tbFelso.Location = new System.Drawing.Point(247, 60);
            this.tbFelso.Name = "tbFelso";
            this.tbFelso.Size = new System.Drawing.Size(100, 26);
            this.tbFelso.TabIndex = 0;
            // 
            // tbSzam
            // 
            this.tbSzam.Location = new System.Drawing.Point(31, 146);
            this.tbSzam.Name = "tbSzam";
            this.tbSzam.Size = new System.Drawing.Size(125, 26);
            this.tbSzam.TabIndex = 0;
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEredmeny.Location = new System.Drawing.Point(12, 198);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(335, 40);
            this.lblEredmeny.TabIndex = 1;
            this.lblEredmeny.Text = "###placeholder text###";
            this.lblEredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 247);
            this.Controls.Add(this.btnMegallapit);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.lblMegadottSzam);
            this.Controls.Add(this.lblFelso);
            this.Controls.Add(this.lblAlso);
            this.Controls.Add(this.tbSzam);
            this.Controls.Add(this.tbFelso);
            this.Controls.Add(this.tbAlso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Intervallum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAlso;
        private System.Windows.Forms.Label lblAlso;
        private System.Windows.Forms.Button btnMegallapit;
        private System.Windows.Forms.Label lblFelso;
        private System.Windows.Forms.Label lblMegadottSzam;
        private System.Windows.Forms.TextBox tbFelso;
        private System.Windows.Forms.TextBox tbSzam;
        private System.Windows.Forms.Label lblEredmeny;
    }
}


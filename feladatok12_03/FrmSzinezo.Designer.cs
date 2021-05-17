
namespace feladatok12_03
{
    partial class FrmSzinezo
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.btnAlaphelyzet = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kattints valamelyik színes téglalapra!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(64, 99);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(254, 74);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(64, 196);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(254, 74);
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(64, 293);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(254, 74);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(64, 390);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(254, 74);
            this.pb4.TabIndex = 2;
            this.pb4.TabStop = false;
            // 
            // btnAlaphelyzet
            // 
            this.btnAlaphelyzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlaphelyzet.Location = new System.Drawing.Point(12, 506);
            this.btnAlaphelyzet.Name = "btnAlaphelyzet";
            this.btnAlaphelyzet.Size = new System.Drawing.Size(164, 52);
            this.btnAlaphelyzet.TabIndex = 3;
            this.btnAlaphelyzet.Text = "Alaphelyzet";
            this.btnAlaphelyzet.UseVisualStyleBackColor = true;
            this.btnAlaphelyzet.Click += new System.EventHandler(this.BtnAlaphelyzet_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.Location = new System.Drawing.Point(206, 506);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(164, 52);
            this.btnKilepes.TabIndex = 3;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // FrmSzinezo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 591);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnAlaphelyzet);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSzinezo";
            this.Text = "Színező";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnAlaphelyzet;
        private System.Windows.Forms.Button btnKilepes;
    }
}


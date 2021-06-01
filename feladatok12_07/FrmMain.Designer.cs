
namespace feladatok12_07
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
            this.tbDB = new System.Windows.Forms.TextBox();
            this.rtbDobasok = new System.Windows.Forms.RichTextBox();
            this.btnDobas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hány kockadobást kérsz?";
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(250, 12);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(110, 26);
            this.tbDB.TabIndex = 1;
            // 
            // rtbDobasok
            // 
            this.rtbDobasok.Location = new System.Drawing.Point(12, 44);
            this.rtbDobasok.Name = "rtbDobasok";
            this.rtbDobasok.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDobasok.Size = new System.Drawing.Size(348, 219);
            this.rtbDobasok.TabIndex = 2;
            this.rtbDobasok.Text = "";
            // 
            // btnDobas
            // 
            this.btnDobas.Location = new System.Drawing.Point(12, 277);
            this.btnDobas.Name = "btnDobas";
            this.btnDobas.Size = new System.Drawing.Size(348, 44);
            this.btnDobas.TabIndex = 3;
            this.btnDobas.Text = "Dobás";
            this.btnDobas.UseVisualStyleBackColor = true;
            this.btnDobas.Click += new System.EventHandler(this.BtnDobas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 333);
            this.Controls.Add(this.btnDobas);
            this.Controls.Add(this.rtbDobasok);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Kockadobások";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.RichTextBox rtbDobasok;
        private System.Windows.Forms.Button btnDobas;
    }
}


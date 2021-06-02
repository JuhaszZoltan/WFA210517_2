
namespace feladatok12_15
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
            this.tbKedvencSzo = new System.Windows.Forms.TextBox();
            this.btnTunjEl = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pbSmiley = new System.Windows.Forms.PictureBox();
            this.btnGyereVissza = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmiley)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(121, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi a kedvenc szavad?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbKedvencSzo
            // 
            this.tbKedvencSzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKedvencSzo.Location = new System.Drawing.Point(121, 86);
            this.tbKedvencSzo.Name = "tbKedvencSzo";
            this.tbKedvencSzo.Size = new System.Drawing.Size(740, 34);
            this.tbKedvencSzo.TabIndex = 1;
            this.tbKedvencSzo.TextChanged += new System.EventHandler(this.TbKedvencSzo_TextChanged);
            // 
            // btnTunjEl
            // 
            this.btnTunjEl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTunjEl.Location = new System.Drawing.Point(121, 477);
            this.btnTunjEl.Name = "btnTunjEl";
            this.btnTunjEl.Size = new System.Drawing.Size(200, 64);
            this.btnTunjEl.TabIndex = 3;
            this.btnTunjEl.Text = "Tűnj el!";
            this.btnTunjEl.UseVisualStyleBackColor = true;
            this.btnTunjEl.Click += new System.EventHandler(this.btnTunjEl_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pbSmiley);
            this.panel.Location = new System.Drawing.Point(121, 126);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(740, 345);
            this.panel.TabIndex = 4;
            // 
            // pbSmiley
            // 
            this.pbSmiley.Image = global::feladatok12_15.Properties.Resources.smiley_open;
            this.pbSmiley.Location = new System.Drawing.Point(270, 72);
            this.pbSmiley.Name = "pbSmiley";
            this.pbSmiley.Size = new System.Drawing.Size(200, 200);
            this.pbSmiley.TabIndex = 0;
            this.pbSmiley.TabStop = false;
            this.pbSmiley.Click += new System.EventHandler(this.pbSmiley_Click);
            this.pbSmiley.MouseEnter += new System.EventHandler(this.PbSmiley_MouseEnter);
            this.pbSmiley.MouseLeave += new System.EventHandler(this.pbSmiley_MouseLeave);
            // 
            // btnGyereVissza
            // 
            this.btnGyereVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGyereVissza.Location = new System.Drawing.Point(661, 477);
            this.btnGyereVissza.Name = "btnGyereVissza";
            this.btnGyereVissza.Size = new System.Drawing.Size(200, 64);
            this.btnGyereVissza.TabIndex = 3;
            this.btnGyereVissza.Text = "Gyere Vissza!";
            this.btnGyereVissza.UseVisualStyleBackColor = true;
            this.btnGyereVissza.Click += new System.EventHandler(this.btnGyereVissza_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnGyereVissza);
            this.Controls.Add(this.btnTunjEl);
            this.Controls.Add(this.tbKedvencSzo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Mittudomén";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSmiley)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKedvencSzo;
        private System.Windows.Forms.Button btnTunjEl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbSmiley;
        private System.Windows.Forms.Button btnGyereVissza;
    }
}


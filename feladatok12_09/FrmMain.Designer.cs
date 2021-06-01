
namespace feladatok12_09
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnOsszesTorles = new System.Windows.Forms.Button();
            this.btnKijeloltTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(13, 62);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(188, 26);
            this.tbInput.TabIndex = 0;
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 20;
            this.lbLista.Location = new System.Drawing.Point(13, 108);
            this.lbLista.Name = "lbLista";
            this.lbLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLista.Size = new System.Drawing.Size(188, 224);
            this.lbLista.TabIndex = 1;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(252, 54);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(179, 66);
            this.btnHozzaad.TabIndex = 2;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.BtnHozzaad_Click);
            // 
            // btnOsszesTorles
            // 
            this.btnOsszesTorles.Location = new System.Drawing.Point(252, 160);
            this.btnOsszesTorles.Name = "btnOsszesTorles";
            this.btnOsszesTorles.Size = new System.Drawing.Size(179, 66);
            this.btnOsszesTorles.TabIndex = 3;
            this.btnOsszesTorles.Text = "Összes törlése";
            this.btnOsszesTorles.UseVisualStyleBackColor = true;
            this.btnOsszesTorles.Click += new System.EventHandler(this.BtnOsszesTorles_Click);
            // 
            // btnKijeloltTorles
            // 
            this.btnKijeloltTorles.Location = new System.Drawing.Point(252, 266);
            this.btnKijeloltTorles.Name = "btnKijeloltTorles";
            this.btnKijeloltTorles.Size = new System.Drawing.Size(179, 66);
            this.btnKijeloltTorles.TabIndex = 4;
            this.btnKijeloltTorles.Text = "Kijelölt törlése";
            this.btnKijeloltTorles.UseVisualStyleBackColor = true;
            this.btnKijeloltTorles.Click += new System.EventHandler(this.btnKijeloltTorles_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 369);
            this.Controls.Add(this.btnKijeloltTorles);
            this.Controls.Add(this.btnOsszesTorles);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.tbInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnOsszesTorles;
        private System.Windows.Forms.Button btnKijeloltTorles;
    }
}


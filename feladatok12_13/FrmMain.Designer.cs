
namespace feladatok12_13
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
            this.btnJatekosKo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJatekosPapir = new System.Windows.Forms.Button();
            this.btnJatekosOllo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJatekosPont = new System.Windows.Forms.Label();
            this.lblGepPont = new System.Windows.Forms.Label();
            this.btnGepKo = new System.Windows.Forms.Button();
            this.btnGepPapir = new System.Windows.Forms.Button();
            this.btnGepOllo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJatekosKo
            // 
            this.btnJatekosKo.BackColor = System.Drawing.Color.White;
            this.btnJatekosKo.Location = new System.Drawing.Point(96, 12);
            this.btnJatekosKo.Name = "btnJatekosKo";
            this.btnJatekosKo.Size = new System.Drawing.Size(111, 36);
            this.btnJatekosKo.TabIndex = 1;
            this.btnJatekosKo.Text = "Kő";
            this.btnJatekosKo.UseVisualStyleBackColor = false;
            this.btnJatekosKo.Click += new System.EventHandler(this.JatekosButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "játékos:";
            // 
            // btnJatekosPapir
            // 
            this.btnJatekosPapir.BackColor = System.Drawing.Color.White;
            this.btnJatekosPapir.Location = new System.Drawing.Point(213, 12);
            this.btnJatekosPapir.Name = "btnJatekosPapir";
            this.btnJatekosPapir.Size = new System.Drawing.Size(111, 36);
            this.btnJatekosPapir.TabIndex = 2;
            this.btnJatekosPapir.Text = "Papír";
            this.btnJatekosPapir.UseVisualStyleBackColor = false;
            this.btnJatekosPapir.Click += new System.EventHandler(this.JatekosButton_Click);
            // 
            // btnJatekosOllo
            // 
            this.btnJatekosOllo.BackColor = System.Drawing.Color.White;
            this.btnJatekosOllo.Location = new System.Drawing.Point(330, 12);
            this.btnJatekosOllo.Name = "btnJatekosOllo";
            this.btnJatekosOllo.Size = new System.Drawing.Size(111, 36);
            this.btnJatekosOllo.TabIndex = 3;
            this.btnJatekosOllo.Text = "Olló";
            this.btnJatekosOllo.UseVisualStyleBackColor = false;
            this.btnJatekosOllo.Click += new System.EventHandler(this.JatekosButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "gép:";
            // 
            // lblJatekosPont
            // 
            this.lblJatekosPont.AutoSize = true;
            this.lblJatekosPont.Location = new System.Drawing.Point(447, 20);
            this.lblJatekosPont.Name = "lblJatekosPont";
            this.lblJatekosPont.Size = new System.Drawing.Size(55, 20);
            this.lblJatekosPont.TabIndex = 1;
            this.lblJatekosPont.Text = "# pont";
            // 
            // lblGepPont
            // 
            this.lblGepPont.AutoSize = true;
            this.lblGepPont.Location = new System.Drawing.Point(447, 62);
            this.lblGepPont.Name = "lblGepPont";
            this.lblGepPont.Size = new System.Drawing.Size(55, 20);
            this.lblGepPont.TabIndex = 1;
            this.lblGepPont.Text = "# pont";
            // 
            // btnGepKo
            // 
            this.btnGepKo.BackColor = System.Drawing.Color.White;
            this.btnGepKo.Enabled = false;
            this.btnGepKo.Location = new System.Drawing.Point(96, 54);
            this.btnGepKo.Name = "btnGepKo";
            this.btnGepKo.Size = new System.Drawing.Size(111, 36);
            this.btnGepKo.TabIndex = 0;
            this.btnGepKo.TabStop = false;
            this.btnGepKo.Text = "Kő";
            this.btnGepKo.UseVisualStyleBackColor = false;
            // 
            // btnGepPapir
            // 
            this.btnGepPapir.BackColor = System.Drawing.Color.White;
            this.btnGepPapir.Enabled = false;
            this.btnGepPapir.Location = new System.Drawing.Point(213, 54);
            this.btnGepPapir.Name = "btnGepPapir";
            this.btnGepPapir.Size = new System.Drawing.Size(111, 36);
            this.btnGepPapir.TabIndex = 0;
            this.btnGepPapir.TabStop = false;
            this.btnGepPapir.Text = "Papír";
            this.btnGepPapir.UseVisualStyleBackColor = false;
            // 
            // btnGepOllo
            // 
            this.btnGepOllo.BackColor = System.Drawing.Color.White;
            this.btnGepOllo.Enabled = false;
            this.btnGepOllo.Location = new System.Drawing.Point(330, 54);
            this.btnGepOllo.Name = "btnGepOllo";
            this.btnGepOllo.Size = new System.Drawing.Size(111, 36);
            this.btnGepOllo.TabIndex = 0;
            this.btnGepOllo.TabStop = false;
            this.btnGepOllo.Text = "Olló";
            this.btnGepOllo.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 103);
            this.Controls.Add(this.lblGepPont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJatekosPont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGepOllo);
            this.Controls.Add(this.btnJatekosOllo);
            this.Controls.Add(this.btnGepPapir);
            this.Controls.Add(this.btnJatekosPapir);
            this.Controls.Add(this.btnGepKo);
            this.Controls.Add(this.btnJatekosKo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Kő-Papír-Olló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJatekosKo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJatekosPapir;
        private System.Windows.Forms.Button btnJatekosOllo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJatekosPont;
        private System.Windows.Forms.Label lblGepPont;
        private System.Windows.Forms.Button btnGepKo;
        private System.Windows.Forms.Button btnGepPapir;
        private System.Windows.Forms.Button btnGepOllo;
    }
}


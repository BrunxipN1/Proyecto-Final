namespace Proyecto
{
    partial class WTrivia
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
            this.LPregunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LRespuesta1 = new System.Windows.Forms.Label();
            this.LRespuesta2 = new System.Windows.Forms.Label();
            this.LRespuesta3 = new System.Windows.Forms.Label();
            this.LRespuesta4 = new System.Windows.Forms.Label();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.PictureBox();
            this.LResultado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.LTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).BeginInit();
            this.SuspendLayout();
            // 
            // LPregunta
            // 
            this.LPregunta.AutoSize = true;
            this.LPregunta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LPregunta.ForeColor = System.Drawing.Color.BurlyWood;
            this.LPregunta.Location = new System.Drawing.Point(31, 34);
            this.LPregunta.MaximumSize = new System.Drawing.Size(450, 150);
            this.LPregunta.Name = "LPregunta";
            this.LPregunta.Size = new System.Drawing.Size(111, 25);
            this.LPregunta.TabIndex = 1;
            this.LPregunta.Text = "LPregunta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(21, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 123);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(21, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 225);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // LRespuesta1
            // 
            this.LRespuesta1.AutoSize = true;
            this.LRespuesta1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LRespuesta1.ForeColor = System.Drawing.Color.SeaShell;
            this.LRespuesta1.Location = new System.Drawing.Point(31, 164);
            this.LRespuesta1.MaximumSize = new System.Drawing.Size(400, 40);
            this.LRespuesta1.MinimumSize = new System.Drawing.Size(300, 0);
            this.LRespuesta1.Name = "LRespuesta1";
            this.LRespuesta1.Size = new System.Drawing.Size(300, 20);
            this.LRespuesta1.TabIndex = 4;
            this.LRespuesta1.Text = "LRespuesta1";
            this.LRespuesta1.Click += new System.EventHandler(this.LRespuesta1_Click);
            // 
            // LRespuesta2
            // 
            this.LRespuesta2.AutoSize = true;
            this.LRespuesta2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LRespuesta2.ForeColor = System.Drawing.Color.SeaShell;
            this.LRespuesta2.Location = new System.Drawing.Point(32, 214);
            this.LRespuesta2.MaximumSize = new System.Drawing.Size(400, 40);
            this.LRespuesta2.MinimumSize = new System.Drawing.Size(300, 0);
            this.LRespuesta2.Name = "LRespuesta2";
            this.LRespuesta2.Size = new System.Drawing.Size(300, 20);
            this.LRespuesta2.TabIndex = 5;
            this.LRespuesta2.Text = "LRespuesta2";
            this.LRespuesta2.Click += new System.EventHandler(this.LRespuesta2_Click);
            // 
            // LRespuesta3
            // 
            this.LRespuesta3.AutoSize = true;
            this.LRespuesta3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LRespuesta3.ForeColor = System.Drawing.Color.SeaShell;
            this.LRespuesta3.Location = new System.Drawing.Point(32, 265);
            this.LRespuesta3.MaximumSize = new System.Drawing.Size(400, 40);
            this.LRespuesta3.MinimumSize = new System.Drawing.Size(300, 0);
            this.LRespuesta3.Name = "LRespuesta3";
            this.LRespuesta3.Size = new System.Drawing.Size(300, 20);
            this.LRespuesta3.TabIndex = 6;
            this.LRespuesta3.Text = "LRespuesta3";
            this.LRespuesta3.Click += new System.EventHandler(this.Respuesta3_Click);
            // 
            // LRespuesta4
            // 
            this.LRespuesta4.AutoSize = true;
            this.LRespuesta4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LRespuesta4.ForeColor = System.Drawing.Color.SeaShell;
            this.LRespuesta4.Location = new System.Drawing.Point(32, 313);
            this.LRespuesta4.MaximumSize = new System.Drawing.Size(400, 40);
            this.LRespuesta4.MinimumSize = new System.Drawing.Size(300, 0);
            this.LRespuesta4.Name = "LRespuesta4";
            this.LRespuesta4.Size = new System.Drawing.Size(300, 20);
            this.LRespuesta4.TabIndex = 7;
            this.LRespuesta4.Text = "LRespuesta4";
            this.LRespuesta4.Click += new System.EventHandler(this.LRespuesta4_Click);
            // 
            // BSiguiente
            // 
            this.BSiguiente.Enabled = false;
            this.BSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSiguiente.Location = new System.Drawing.Point(432, 398);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(89, 27);
            this.BSiguiente.TabIndex = 8;
            this.BSiguiente.Text = "Next";
            this.BSiguiente.UseVisualStyleBackColor = true;
            this.BSiguiente.Click += new System.EventHandler(this.BSiguiente_Click);
            // 
            // L
            // 
            this.L.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L.Location = new System.Drawing.Point(21, 398);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(292, 27);
            this.L.TabIndex = 10;
            this.L.TabStop = false;
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LResultado.Enabled = false;
            this.LResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LResultado.ForeColor = System.Drawing.Color.BurlyWood;
            this.LResultado.Location = new System.Drawing.Point(106, 398);
            this.LResultado.MaximumSize = new System.Drawing.Size(450, 150);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(121, 25);
            this.LResultado.TabIndex = 11;
            this.LResultado.Text = "LResultado";
            this.LResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            this.Timer2.Interval = 1000;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // LTimer
            // 
            this.LTimer.AutoSize = true;
            this.LTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LTimer.ForeColor = System.Drawing.Color.LightGreen;
            this.LTimer.Location = new System.Drawing.Point(427, 339);
            this.LTimer.MaximumSize = new System.Drawing.Size(450, 150);
            this.LTimer.Name = "LTimer";
            this.LTimer.Size = new System.Drawing.Size(78, 25);
            this.LTimer.TabIndex = 12;
            this.LTimer.Text = "LTimer";
            // 
            // WTrivia
            // 
            this.AcceptButton = this.BSiguiente;
            this.ClientSize = new System.Drawing.Size(544, 437);
            this.Controls.Add(this.LTimer);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.L);
            this.Controls.Add(this.BSiguiente);
            this.Controls.Add(this.LRespuesta4);
            this.Controls.Add(this.LRespuesta3);
            this.Controls.Add(this.LRespuesta2);
            this.Controls.Add(this.LRespuesta1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LPregunta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WTrivia";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WTrivia_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPregunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LRespuesta1;
        private System.Windows.Forms.Label LRespuesta2;
        private System.Windows.Forms.Label LRespuesta3;
        private System.Windows.Forms.Label LRespuesta4;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.PictureBox L;
        private System.Windows.Forms.Label LResultado;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Label LTimer;
    }
}
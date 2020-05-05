namespace Proyecto
{
    partial class WMain
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
            this.VerPuntuaciones = new System.Windows.Forms.Button();
            this.PreguntaManual = new System.Windows.Forms.Button();
            this.PreguntaWeb = new System.Windows.Forms.Button();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.BJugar = new System.Windows.Forms.Button();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.BQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerPuntuaciones
            // 
            this.VerPuntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerPuntuaciones.Location = new System.Drawing.Point(76, 255);
            this.VerPuntuaciones.Name = "VerPuntuaciones";
            this.VerPuntuaciones.Size = new System.Drawing.Size(238, 35);
            this.VerPuntuaciones.TabIndex = 2;
            this.VerPuntuaciones.Text = "Scores";
            this.VerPuntuaciones.UseVisualStyleBackColor = true;
            this.VerPuntuaciones.Click += new System.EventHandler(this.VerPuntajes_Click);
            // 
            // PreguntaManual
            // 
            this.PreguntaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaManual.Location = new System.Drawing.Point(76, 174);
            this.PreguntaManual.Name = "PreguntaManual";
            this.PreguntaManual.Size = new System.Drawing.Size(238, 35);
            this.PreguntaManual.TabIndex = 3;
            this.PreguntaManual.Text = "Add Question Manually";
            this.PreguntaManual.UseVisualStyleBackColor = true;
            this.PreguntaManual.Click += new System.EventHandler(this.PreguntaManual_Click);
            // 
            // PreguntaWeb
            // 
            this.PreguntaWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaWeb.Location = new System.Drawing.Point(76, 215);
            this.PreguntaWeb.Name = "PreguntaWeb";
            this.PreguntaWeb.Size = new System.Drawing.Size(238, 34);
            this.PreguntaWeb.TabIndex = 4;
            this.PreguntaWeb.Text = "Add Questions by Web";
            this.PreguntaWeb.UseVisualStyleBackColor = true;
            this.PreguntaWeb.Click += new System.EventHandler(this.PreguntaWeb_Click);
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(12, 13);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(100, 13);
            this.LNombreUsuario.TabIndex = 7;
            this.LNombreUsuario.Text = "LNombreUsuario";
            this.LNombreUsuario.Click += new System.EventHandler(this.VerPreguntas_Click);
            // 
            // BJugar
            // 
            this.BJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.BJugar.Location = new System.Drawing.Point(76, 65);
            this.BJugar.Name = "BJugar";
            this.BJugar.Size = new System.Drawing.Size(238, 63);
            this.BJugar.TabIndex = 8;
            this.BJugar.Text = "Play";
            this.BJugar.UseVisualStyleBackColor = true;
            this.BJugar.Click += new System.EventHandler(this.BJugar_Click);
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold);
            this.BCerrarSesion.Location = new System.Drawing.Point(280, 9);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(97, 25);
            this.BCerrarSesion.TabIndex = 9;
            this.BCerrarSesion.Text = "Log Out";
            this.BCerrarSesion.UseVisualStyleBackColor = true;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // BQuit
            // 
            this.BQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BQuit.Location = new System.Drawing.Point(76, 296);
            this.BQuit.Name = "BQuit";
            this.BQuit.Size = new System.Drawing.Size(238, 35);
            this.BQuit.TabIndex = 10;
            this.BQuit.Text = "Quit";
            this.BQuit.UseVisualStyleBackColor = true;
            this.BQuit.Click += new System.EventHandler(this.BQuit_Click);
            // 
            // WMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 349);
            this.Controls.Add(this.BQuit);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.BJugar);
            this.Controls.Add(this.LNombreUsuario);
            this.Controls.Add(this.PreguntaWeb);
            this.Controls.Add(this.PreguntaManual);
            this.Controls.Add(this.VerPuntuaciones);
            this.Name = "WMain";
            this.Text = "Trivia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VerPuntuaciones;
        private System.Windows.Forms.Button PreguntaManual;
        private System.Windows.Forms.Button PreguntaWeb;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.Button BJugar;
        private System.Windows.Forms.Button BCerrarSesion;
        private System.Windows.Forms.Button BQuit;
    }
}
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
            this.VerPreguntas = new System.Windows.Forms.Button();
            this.PreguntaManual = new System.Windows.Forms.Button();
            this.PreguntaWeb = new System.Windows.Forms.Button();
            this.AgregarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerPreguntas
            // 
            this.VerPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerPreguntas.Location = new System.Drawing.Point(12, 103);
            this.VerPreguntas.Name = "VerPreguntas";
            this.VerPreguntas.Size = new System.Drawing.Size(238, 35);
            this.VerPreguntas.TabIndex = 2;
            this.VerPreguntas.Text = "Puto el que lee";
            this.VerPreguntas.UseVisualStyleBackColor = true;
            this.VerPreguntas.Click += new System.EventHandler(this.VerPreguntas_Click);
            // 
            // PreguntaManual
            // 
            this.PreguntaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaManual.Location = new System.Drawing.Point(12, 22);
            this.PreguntaManual.Name = "PreguntaManual";
            this.PreguntaManual.Size = new System.Drawing.Size(238, 35);
            this.PreguntaManual.TabIndex = 3;
            this.PreguntaManual.Text = "Agregar pregunta manual";
            this.PreguntaManual.UseVisualStyleBackColor = true;
            this.PreguntaManual.Click += new System.EventHandler(this.PreguntaManual_Click);
            // 
            // PreguntaWeb
            // 
            this.PreguntaWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaWeb.Location = new System.Drawing.Point(12, 63);
            this.PreguntaWeb.Name = "PreguntaWeb";
            this.PreguntaWeb.Size = new System.Drawing.Size(238, 34);
            this.PreguntaWeb.TabIndex = 4;
            this.PreguntaWeb.Text = "Agregar Pregunta por web";
            this.PreguntaWeb.UseVisualStyleBackColor = true;
            this.PreguntaWeb.Click += new System.EventHandler(this.PreguntaWeb_Click);
            // 
            // AgregarCategoria
            // 
            this.AgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarCategoria.Location = new System.Drawing.Point(283, 22);
            this.AgregarCategoria.Name = "AgregarCategoria";
            this.AgregarCategoria.Size = new System.Drawing.Size(238, 35);
            this.AgregarCategoria.TabIndex = 5;
            this.AgregarCategoria.Text = "Agregar Categoria";
            this.AgregarCategoria.UseVisualStyleBackColor = true;
            this.AgregarCategoria.Click += new System.EventHandler(this.AgregarCategoria_Click);
            // 
            // WMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 152);
            this.Controls.Add(this.AgregarCategoria);
            this.Controls.Add(this.PreguntaWeb);
            this.Controls.Add(this.PreguntaManual);
            this.Controls.Add(this.VerPreguntas);
            this.Name = "WMain";
            this.Text = "Coso de preguntas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button VerPreguntas;
        private System.Windows.Forms.Button PreguntaManual;
        private System.Windows.Forms.Button PreguntaWeb;
        private System.Windows.Forms.Button AgregarCategoria;
    }
}
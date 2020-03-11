namespace Proyecto
{
    partial class WAgregarCategoria
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
            this.TCategoria = new System.Windows.Forms.TextBox();
            this.lCategoría = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese los datos que se piden a continuación";
            // 
            // TCategoria
            // 
            this.TCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCategoria.Location = new System.Drawing.Point(130, 76);
            this.TCategoria.Multiline = true;
            this.TCategoria.Name = "TCategoria";
            this.TCategoria.Size = new System.Drawing.Size(274, 25);
            this.TCategoria.TabIndex = 5;
            this.TCategoria.TextChanged += new System.EventHandler(this.TCategoria_TextChanged);
            // 
            // lCategoría
            // 
            this.lCategoría.AutoSize = true;
            this.lCategoría.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategoría.Location = new System.Drawing.Point(32, 77);
            this.lCategoría.Name = "lCategoría";
            this.lCategoría.Size = new System.Drawing.Size(92, 18);
            this.lCategoría.TabIndex = 4;
            this.lCategoría.Text = "Categoría:";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(247, 133);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(128, 32);
            this.Aceptar.TabIndex = 16;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(52, 133);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(145, 32);
            this.Cancelar.TabIndex = 15;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // WAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 177);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.TCategoria);
            this.Controls.Add(this.lCategoría);
            this.Controls.Add(this.label1);
            this.Name = "WAgregarCategoria";
            this.Text = "WAgregarCategoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WAgregarCategoria_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WAgregarCategoria_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCategoria;
        private System.Windows.Forms.Label lCategoría;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
    }
}
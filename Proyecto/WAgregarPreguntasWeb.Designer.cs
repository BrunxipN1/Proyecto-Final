namespace Proyecto
{
    partial class WAgregarPreguntasWeb
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
            this.label2 = new System.Windows.Forms.Label();
            this.TCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TDificultad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.TCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the requested information to \r\nautomatically add questions by web";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category:";
            // 
            // TCategoria
            // 
            this.TCategoria.AccessibleName = "";
            this.TCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TCategoria.FormattingEnabled = true;
            this.TCategoria.Location = new System.Drawing.Point(217, 94);
            this.TCategoria.Name = "TCategoria";
            this.TCategoria.Size = new System.Drawing.Size(212, 21);
            this.TCategoria.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Difficulty:";
            // 
            // TDificultad
            // 
            this.TDificultad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TDificultad.DisplayMember = "NombreDificultad";
            this.TDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TDificultad.FormattingEnabled = true;
            this.TDificultad.Location = new System.Drawing.Point(217, 141);
            this.TDificultad.Name = "TDificultad";
            this.TDificultad.Size = new System.Drawing.Size(212, 21);
            this.TDificultad.TabIndex = 6;
            this.TDificultad.ValueMember = "IdDificultad";
            this.TDificultad.SelectedIndexChanged += new System.EventHandler(this.TDificultad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount:";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(75, 306);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(145, 32);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancel";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(256, 306);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(128, 32);
            this.Aceptar.TabIndex = 14;
            this.Aceptar.Text = "Accept";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // TCantidad
            // 
            this.TCantidad.Location = new System.Drawing.Point(217, 215);
            this.TCantidad.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(212, 20);
            this.TCantidad.TabIndex = 15;
            // 
            // WAgregarPreguntasWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 372);
            this.Controls.Add(this.TCantidad);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TDificultad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "WAgregarPreguntasWeb";
            this.Text = "Trivia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WPreguntaManual_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TDificultad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.NumericUpDown TCantidad;
    }
}
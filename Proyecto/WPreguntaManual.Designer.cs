namespace Proyecto
{
    partial class WPreguntaManual
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
            this.lPregunta = new System.Windows.Forms.Label();
            this.TPregunta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TDificultad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TRespuestaCorrecta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TRespIncorrecta1 = new System.Windows.Forms.TextBox();
            this.TRespIncorrecta2 = new System.Windows.Forms.TextBox();
            this.TRespIncorrecta3 = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this._Proyecto_TriviaContextDataSet1 = new Proyecto._Proyecto_TriviaContextDataSet1();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new Proyecto._Proyecto_TriviaContextDataSet1TableAdapters.CategoriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Proyecto_TriviaContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lPregunta
            // 
            this.lPregunta.AutoSize = true;
            this.lPregunta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPregunta.Location = new System.Drawing.Point(43, 66);
            this.lPregunta.Name = "lPregunta";
            this.lPregunta.Size = new System.Drawing.Size(87, 18);
            this.lPregunta.TabIndex = 0;
            this.lPregunta.Text = "Pregunta:";
            // 
            // TPregunta
            // 
            this.TPregunta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPregunta.Location = new System.Drawing.Point(140, 68);
            this.TPregunta.Multiline = true;
            this.TPregunta.Name = "TPregunta";
            this.TPregunta.Size = new System.Drawing.Size(587, 47);
            this.TPregunta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese los datos que se piden a continuación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoría:";
            // 
            // TCategoria
            // 
            this.TCategoria.AccessibleName = "";
            this.TCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TCategoria.DataSource = this.categoriasBindingSource;
            this.TCategoria.DisplayMember = "NombreCategoria";
            this.TCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TCategoria.FormattingEnabled = true;
            this.TCategoria.Location = new System.Drawing.Point(140, 155);
            this.TCategoria.Name = "TCategoria";
            this.TCategoria.Size = new System.Drawing.Size(212, 21);
            this.TCategoria.TabIndex = 4;
            this.TCategoria.Tag = "iCategoriaSeleccionada";
            this.TCategoria.ValueMember = "IdCategoria";
            this.TCategoria.SelectedIndexChanged += new System.EventHandler(this.TCategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dificultad:";
            // 
            // TDificultad
            // 
            this.TDificultad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TDificultad.FormattingEnabled = true;
            this.TDificultad.Location = new System.Drawing.Point(515, 154);
            this.TDificultad.Name = "TDificultad";
            this.TDificultad.Size = new System.Drawing.Size(212, 21);
            this.TDificultad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Respuesta Correcta:";
            // 
            // TRespuestaCorrecta
            // 
            this.TRespuestaCorrecta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRespuestaCorrecta.Location = new System.Drawing.Point(224, 218);
            this.TRespuestaCorrecta.Multiline = true;
            this.TRespuestaCorrecta.Name = "TRespuestaCorrecta";
            this.TRespuestaCorrecta.Size = new System.Drawing.Size(503, 18);
            this.TRespuestaCorrecta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Respuestas incorrectas:";
            // 
            // TRespIncorrecta1
            // 
            this.TRespIncorrecta1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRespIncorrecta1.Location = new System.Drawing.Point(46, 289);
            this.TRespIncorrecta1.Multiline = true;
            this.TRespIncorrecta1.Name = "TRespIncorrecta1";
            this.TRespIncorrecta1.Size = new System.Drawing.Size(503, 18);
            this.TRespIncorrecta1.TabIndex = 10;
            // 
            // TRespIncorrecta2
            // 
            this.TRespIncorrecta2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRespIncorrecta2.Location = new System.Drawing.Point(46, 313);
            this.TRespIncorrecta2.Multiline = true;
            this.TRespIncorrecta2.Name = "TRespIncorrecta2";
            this.TRespIncorrecta2.Size = new System.Drawing.Size(503, 18);
            this.TRespIncorrecta2.TabIndex = 11;
            // 
            // TRespIncorrecta3
            // 
            this.TRespIncorrecta3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRespIncorrecta3.Location = new System.Drawing.Point(46, 337);
            this.TRespIncorrecta3.Multiline = true;
            this.TRespIncorrecta3.Name = "TRespIncorrecta3";
            this.TRespIncorrecta3.Size = new System.Drawing.Size(503, 18);
            this.TRespIncorrecta3.TabIndex = 12;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(404, 406);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(145, 32);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(599, 406);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(128, 32);
            this.Aceptar.TabIndex = 14;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // _Proyecto_TriviaContextDataSet1
            // 
            this._Proyecto_TriviaContextDataSet1.DataSetName = "_Proyecto_TriviaContextDataSet1";
            this._Proyecto_TriviaContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this._Proyecto_TriviaContextDataSet1;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // WPreguntaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.TRespIncorrecta3);
            this.Controls.Add(this.TRespIncorrecta2);
            this.Controls.Add(this.TRespIncorrecta1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TRespuestaCorrecta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TDificultad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPregunta);
            this.Controls.Add(this.lPregunta);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "WPreguntaManual";
            this.Text = "WPreguntaManual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WPreguntaManual_FormClosing);
            this.Load += new System.EventHandler(this.WPreguntaManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Proyecto_TriviaContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPregunta;
        private System.Windows.Forms.TextBox TPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TDificultad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TRespuestaCorrecta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TRespIncorrecta1;
        private System.Windows.Forms.TextBox TRespIncorrecta2;
        private System.Windows.Forms.TextBox TRespIncorrecta3;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private _Proyecto_TriviaContextDataSet1 _Proyecto_TriviaContextDataSet1;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private _Proyecto_TriviaContextDataSet1TableAdapters.CategoriasTableAdapter categoriasTableAdapter;
    }
}
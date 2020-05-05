namespace Proyecto
{
    partial class WPuntajes
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
            this.LView = new System.Windows.Forms.ListView();
            this.Lugar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puntaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LView
            // 
            this.LView.AllowColumnReorder = true;
            this.LView.BackColor = System.Drawing.SystemColors.MenuText;
            this.LView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lugar,
            this.Usuario,
            this.Puntaje,
            this.Tiempo,
            this.Fecha});
            this.LView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LView.ForeColor = System.Drawing.Color.GreenYellow;
            this.LView.HideSelection = false;
            this.LView.Location = new System.Drawing.Point(12, 12);
            this.LView.Name = "LView";
            this.LView.Size = new System.Drawing.Size(595, 551);
            this.LView.TabIndex = 0;
            this.LView.UseCompatibleStateImageBehavior = false;
            this.LView.View = System.Windows.Forms.View.Details;
            // 
            // Lugar
            // 
            this.Lugar.Text = "Place";
            this.Lugar.Width = 54;
            // 
            // Usuario
            // 
            this.Usuario.Text = "User";
            this.Usuario.Width = 148;
            // 
            // Puntaje
            // 
            this.Puntaje.Text = "Score";
            this.Puntaje.Width = 151;
            // 
            // Tiempo
            // 
            this.Tiempo.Text = "Time";
            this.Tiempo.Width = 99;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Date";
            this.Fecha.Width = 139;
            // 
            // BCerrar
            // 
            this.BCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrar.Location = new System.Drawing.Point(246, 569);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(163, 32);
            this.BCerrar.TabIndex = 1;
            this.BCerrar.Text = "Close";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // WPuntajes
            // 
            this.AcceptButton = this.BCerrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCerrar;
            this.ClientSize = new System.Drawing.Size(622, 608);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.LView);
            this.Name = "WPuntajes";
            this.Text = "Trivia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LView;
        private System.Windows.Forms.ColumnHeader Lugar;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader Puntaje;
        private System.Windows.Forms.ColumnHeader Tiempo;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.Button BCerrar;
    }
}
namespace Proyecto
{
    partial class WIniciarSesion
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
            this.TUsername = new System.Windows.Forms.TextBox();
            this.TPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BQuit = new System.Windows.Forms.Button();
            this.BLogin = new System.Windows.Forms.Button();
            this.LCreate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // TUsername
            // 
            this.TUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUsername.Location = new System.Drawing.Point(163, 73);
            this.TUsername.Name = "TUsername";
            this.TUsername.Size = new System.Drawing.Size(217, 23);
            this.TUsername.TabIndex = 2;
            // 
            // TPass
            // 
            this.TPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.Location = new System.Drawing.Point(163, 119);
            this.TPass.Name = "TPass";
            this.TPass.Size = new System.Drawing.Size(217, 23);
            this.TPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login with your Username and Password";
            // 
            // BQuit
            // 
            this.BQuit.Location = new System.Drawing.Point(56, 215);
            this.BQuit.Name = "BQuit";
            this.BQuit.Size = new System.Drawing.Size(108, 30);
            this.BQuit.TabIndex = 5;
            this.BQuit.Text = "Quit";
            this.BQuit.UseVisualStyleBackColor = true;
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(272, 215);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(108, 30);
            this.BLogin.TabIndex = 6;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // LCreate
            // 
            this.LCreate.AutoSize = true;
            this.LCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCreate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LCreate.Location = new System.Drawing.Point(53, 170);
            this.LCreate.Name = "LCreate";
            this.LCreate.Size = new System.Drawing.Size(133, 17);
            this.LCreate.TabIndex = 7;
            this.LCreate.Text = "Create new account";
            this.LCreate.Click += new System.EventHandler(this.LCreate_Click);
            // 
            // WIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 257);
            this.Controls.Add(this.LCreate);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.BQuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TPass);
            this.Controls.Add(this.TUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WIniciarSesion";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TUsername;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BQuit;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label LCreate;
    }
}
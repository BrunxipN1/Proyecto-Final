namespace Proyecto
{
    partial class WRegistrarse
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
            this.BCreateAccount = new System.Windows.Forms.Button();
            this.BQuit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TPass = new System.Windows.Forms.TextBox();
            this.TUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LUsernameTaken = new System.Windows.Forms.Label();
            this.LPassMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCreateAccount
            // 
            this.BCreateAccount.Location = new System.Drawing.Point(253, 218);
            this.BCreateAccount.Name = "BCreateAccount";
            this.BCreateAccount.Size = new System.Drawing.Size(108, 30);
            this.BCreateAccount.TabIndex = 5;
            this.BCreateAccount.Text = "Create Account";
            this.BCreateAccount.UseVisualStyleBackColor = true;
            this.BCreateAccount.Click += new System.EventHandler(this.BCreateAccount_Click);
            // 
            // BQuit
            // 
            this.BQuit.Location = new System.Drawing.Point(37, 218);
            this.BQuit.Name = "BQuit";
            this.BQuit.Size = new System.Drawing.Size(108, 30);
            this.BQuit.TabIndex = 4;
            this.BQuit.Text = "Quit";
            this.BQuit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login with your Username and Password";
            // 
            // TPass
            // 
            this.TPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.Location = new System.Drawing.Point(144, 119);
            this.TPass.MaxLength = 16;
            this.TPass.Name = "TPass";
            this.TPass.Size = new System.Drawing.Size(217, 23);
            this.TPass.TabIndex = 2;
            this.TPass.UseSystemPasswordChar = true;
            // 
            // TUser
            // 
            this.TUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUser.Location = new System.Drawing.Point(144, 76);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(217, 23);
            this.TUser.TabIndex = 1;
            this.TUser.TextChanged += new System.EventHandler(this.TUser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // TConfirm
            // 
            this.TConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TConfirm.Location = new System.Drawing.Point(144, 161);
            this.TConfirm.MaxLength = 16;
            this.TConfirm.Name = "TConfirm";
            this.TConfirm.Size = new System.Drawing.Size(217, 23);
            this.TConfirm.TabIndex = 3;
            this.TConfirm.TextChanged += new System.EventHandler(this.TConfirm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm:\r\n";
            // 
            // LUsernameTaken
            // 
            this.LUsernameTaken.AutoSize = true;
            this.LUsernameTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.LUsernameTaken.ForeColor = System.Drawing.Color.DarkRed;
            this.LUsernameTaken.Location = new System.Drawing.Point(144, 99);
            this.LUsernameTaken.Name = "LUsernameTaken";
            this.LUsernameTaken.Size = new System.Drawing.Size(159, 12);
            this.LUsernameTaken.TabIndex = 17;
            this.LUsernameTaken.Text = "The username has already been taken";
            this.LUsernameTaken.Visible = false;
            // 
            // LPassMatch
            // 
            this.LPassMatch.AutoSize = true;
            this.LPassMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.LPassMatch.ForeColor = System.Drawing.Color.DarkRed;
            this.LPassMatch.Location = new System.Drawing.Point(144, 184);
            this.LPassMatch.Name = "LPassMatch";
            this.LPassMatch.Size = new System.Drawing.Size(119, 12);
            this.LPassMatch.TabIndex = 18;
            this.LPassMatch.Text = "The Passwords don\'t match";
            this.LPassMatch.Visible = false;
            // 
            // WRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.LPassMatch);
            this.Controls.Add(this.LUsernameTaken);
            this.Controls.Add(this.TConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BCreateAccount);
            this.Controls.Add(this.BQuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TPass);
            this.Controls.Add(this.TUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WRegistrarse";
            this.Text = "Sign in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WRegistrarse_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BCreateAccount;
        private System.Windows.Forms.Button BQuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LUsernameTaken;
        private System.Windows.Forms.Label LPassMatch;
    }
}
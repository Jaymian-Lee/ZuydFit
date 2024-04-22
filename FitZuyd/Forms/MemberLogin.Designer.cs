namespace FitZuyd.Forms
{
    partial class MemberLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLogin));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.buttonLoginMember = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.inpUsername = new System.Windows.Forms.TextBox();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(336, 109);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Login";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(9, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // buttonLoginMember
            // 
            this.buttonLoginMember.Location = new System.Drawing.Point(305, 321);
            this.buttonLoginMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoginMember.Name = "buttonLoginMember";
            this.buttonLoginMember.Size = new System.Drawing.Size(76, 31);
            this.buttonLoginMember.TabIndex = 5;
            this.buttonLoginMember.Text = "Login";
            this.buttonLoginMember.UseVisualStyleBackColor = true;
            this.buttonLoginMember.Click += new System.EventHandler(this.buttonLoginMember_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(301, 261);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 16);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(301, 208);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 16);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "Gebruikersnaam";
            // 
            // inpUsername
            // 
            this.inpUsername.Location = new System.Drawing.Point(300, 226);
            this.inpUsername.Name = "inpUsername";
            this.inpUsername.Size = new System.Drawing.Size(200, 22);
            this.inpUsername.TabIndex = 1;
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(301, 279);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.PasswordChar = '*';
            this.inpPassword.Size = new System.Drawing.Size(200, 22);
            this.inpPassword.TabIndex = 2;
            this.inpPassword.UseSystemPasswordChar = true;
            // 
            // MemberLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.inpUsername);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.buttonLoginMember);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberLogin";
            this.Text = "MemberLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button buttonLoginMember;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox inpUsername;
        private System.Windows.Forms.TextBox inpPassword;
    }
}
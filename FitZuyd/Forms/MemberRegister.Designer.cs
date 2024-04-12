namespace FitZuyd.Forms
{
    partial class MemberRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberRegister));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.inpUsername = new System.Windows.Forms.TextBox();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegisterMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(452, 461);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 25);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(452, 378);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(170, 25);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Gebruikersnaam";
            // 
            // inpUsername
            // 
            this.inpUsername.Location = new System.Drawing.Point(450, 406);
            this.inpUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inpUsername.Name = "inpUsername";
            this.inpUsername.Size = new System.Drawing.Size(298, 31);
            this.inpUsername.TabIndex = 9;
            this.inpUsername.TextChanged += new System.EventHandler(this.inpUsername_TextChanged);
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(452, 489);
            this.inpPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(298, 31);
            this.inpPassword.TabIndex = 7;
            this.inpPassword.TextChanged += new System.EventHandler(this.inpPassword_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(414, 195);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 73);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Registreren";
            // 
            // btnRegisterMember
            // 
            this.btnRegisterMember.Location = new System.Drawing.Point(450, 561);
            this.btnRegisterMember.Name = "btnRegisterMember";
            this.btnRegisterMember.Size = new System.Drawing.Size(132, 52);
            this.btnRegisterMember.TabIndex = 18;
            this.btnRegisterMember.Text = "Registreer";
            this.btnRegisterMember.UseVisualStyleBackColor = true;
            this.btnRegisterMember.Click += new System.EventHandler(this.btnRegisterMember_Click);
            // 
            // MemberRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnRegisterMember);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.inpUsername);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberRegister";
            this.Text = "MemberRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox inpUsername;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegisterMember;
    }
}
namespace FitZuyd.Forms
{
    partial class TrainerRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerRegister));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.inpUsername = new System.Windows.Forms.TextBox();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegisterTrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(448, 453);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 25);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(448, 370);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(170, 25);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Gebruikersnaam";
            // 
            // inpUsername
            // 
            this.inpUsername.Location = new System.Drawing.Point(447, 398);
            this.inpUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inpUsername.Name = "inpUsername";
            this.inpUsername.Size = new System.Drawing.Size(298, 31);
            this.inpUsername.TabIndex = 14;
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(448, 481);
            this.inpPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(298, 31);
            this.inpPassword.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(411, 188);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 73);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Registreren";
            // 
            // btnRegisterTrainer
            // 
            this.btnRegisterTrainer.Location = new System.Drawing.Point(447, 554);
            this.btnRegisterTrainer.Name = "btnRegisterTrainer";
            this.btnRegisterTrainer.Size = new System.Drawing.Size(132, 52);
            this.btnRegisterTrainer.TabIndex = 17;
            this.btnRegisterTrainer.Text = "Registreer";
            this.btnRegisterTrainer.UseVisualStyleBackColor = true;
            // 
            // TrainerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnRegisterTrainer);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.inpUsername);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrainerRegister";
            this.Text = "TrainerRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox inpUsername;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegisterTrainer;
    }
}
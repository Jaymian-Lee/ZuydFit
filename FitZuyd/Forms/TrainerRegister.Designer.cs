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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inpFullname = new System.Windows.Forms.TextBox();
            this.inpAge = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(299, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(299, 129);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 16);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Gebruikersnaam";
            // 
            // inpUsername
            // 
            this.inpUsername.Location = new System.Drawing.Point(298, 147);
            this.inpUsername.Name = "inpUsername";
            this.inpUsername.Size = new System.Drawing.Size(200, 22);
            this.inpUsername.TabIndex = 14;
            this.inpUsername.TextChanged += new System.EventHandler(this.inpUsername_TextChanged);
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(299, 200);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(200, 22);
            this.inpPassword.TabIndex = 12;
            this.inpPassword.TextChanged += new System.EventHandler(this.inpPassword_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(274, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 46);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Registreren";
            // 
            // btnRegisterTrainer
            // 
            this.btnRegisterTrainer.Location = new System.Drawing.Point(298, 355);
            this.btnRegisterTrainer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterTrainer.Name = "btnRegisterTrainer";
            this.btnRegisterTrainer.Size = new System.Drawing.Size(88, 33);
            this.btnRegisterTrainer.TabIndex = 17;
            this.btnRegisterTrainer.Text = "Registreer";
            this.btnRegisterTrainer.UseVisualStyleBackColor = true;
            this.btnRegisterTrainer.Click += new System.EventHandler(this.btnRegisterTrainer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Leeftijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Volledige naam";
            // 
            // inpFullname
            // 
            this.inpFullname.Location = new System.Drawing.Point(297, 250);
            this.inpFullname.Name = "inpFullname";
            this.inpFullname.Size = new System.Drawing.Size(200, 22);
            this.inpFullname.TabIndex = 19;
            // 
            // inpAge
            // 
            this.inpAge.Location = new System.Drawing.Point(298, 303);
            this.inpAge.Name = "inpAge";
            this.inpAge.Size = new System.Drawing.Size(200, 22);
            this.inpAge.TabIndex = 18;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(26, 25);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 33);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // TrainerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpFullname);
            this.Controls.Add(this.inpAge);
            this.Controls.Add(this.btnRegisterTrainer);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.inpUsername);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpFullname;
        private System.Windows.Forms.TextBox inpAge;
        private System.Windows.Forms.Button buttonBack;
    }
}
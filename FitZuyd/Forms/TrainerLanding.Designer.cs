namespace FitZuyd.Forms
{
    partial class TrainerLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerLanding));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTrainerRegister = new System.Windows.Forms.Button();
            this.btnTrainerLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(36, 39);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTrainerRegister
            // 
            this.btnTrainerRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainerRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTrainerRegister.Location = new System.Drawing.Point(508, 517);
            this.btnTrainerRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrainerRegister.Name = "btnTrainerRegister";
            this.btnTrainerRegister.Size = new System.Drawing.Size(225, 72);
            this.btnTrainerRegister.TabIndex = 2;
            this.btnTrainerRegister.Text = "Register";
            this.btnTrainerRegister.UseVisualStyleBackColor = true;
            this.btnTrainerRegister.Click += new System.EventHandler(this.btnTrainerRegister_Click);
            // 
            // btnTrainerLogin
            // 
            this.btnTrainerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTrainerLogin.Location = new System.Drawing.Point(508, 406);
            this.btnTrainerLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrainerLogin.Name = "btnTrainerLogin";
            this.btnTrainerLogin.Size = new System.Drawing.Size(225, 72);
            this.btnTrainerLogin.TabIndex = 1;
            this.btnTrainerLogin.Text = "Login";
            this.btnTrainerLogin.UseVisualStyleBackColor = true;
            this.btnTrainerLogin.Click += new System.EventHandler(this.btnTrainerLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(492, 153);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 73);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Trainer";
            // 
            // TrainerLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTrainerRegister);
            this.Controls.Add(this.btnTrainerLogin);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrainerLanding";
            this.Text = "TrainerLanding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTrainerRegister;
        private System.Windows.Forms.Button btnTrainerLogin;
        private System.Windows.Forms.Label lblTitle;
    }
}
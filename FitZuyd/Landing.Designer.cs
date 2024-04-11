namespace FitZuyd
{
    partial class Landing
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(320, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ZuydFit";
            // 
            // btnMember
            // 
            this.btnMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMember.Location = new System.Drawing.Point(331, 212);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(150, 46);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTrainer.Location = new System.Drawing.Point(331, 283);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(150, 46);
            this.btnTrainer.TabIndex = 2;
            this.btnTrainer.Text = "Trainer";
            this.btnTrainer.UseVisualStyleBackColor = true;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrainer);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.lblTitle);
            this.Name = "Landing";
            this.Text = "Landing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnTrainer;
    }
}


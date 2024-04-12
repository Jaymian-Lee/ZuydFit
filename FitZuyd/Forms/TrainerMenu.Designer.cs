namespace FitZuyd.Forms
{
    partial class TrainerMenu
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
            this.labelTrainerText = new System.Windows.Forms.Label();
            this.buttonLocations = new System.Windows.Forms.Button();
            this.buttonActivities = new System.Windows.Forms.Button();
            this.listViewMembers = new System.Windows.Forms.ListView();
            this.buttonProgress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTrainerText
            // 
            this.labelTrainerText.AutoSize = true;
            this.labelTrainerText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainerText.ForeColor = System.Drawing.Color.White;
            this.labelTrainerText.Location = new System.Drawing.Point(58, 60);
            this.labelTrainerText.Name = "labelTrainerText";
            this.labelTrainerText.Size = new System.Drawing.Size(185, 56);
            this.labelTrainerText.TabIndex = 7;
            this.labelTrainerText.Text = "Trainer";
            // 
            // buttonLocations
            // 
            this.buttonLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocations.Location = new System.Drawing.Point(780, 72);
            this.buttonLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLocations.Name = "buttonLocations";
            this.buttonLocations.Size = new System.Drawing.Size(150, 50);
            this.buttonLocations.TabIndex = 6;
            this.buttonLocations.Text = "Locations";
            this.buttonLocations.UseVisualStyleBackColor = true;
            // 
            // buttonActivities
            // 
            this.buttonActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActivities.Location = new System.Drawing.Point(984, 72);
            this.buttonActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonActivities.Name = "buttonActivities";
            this.buttonActivities.Size = new System.Drawing.Size(150, 50);
            this.buttonActivities.TabIndex = 5;
            this.buttonActivities.Text = "Activities";
            this.buttonActivities.UseVisualStyleBackColor = true;
            // 
            // listViewMembers
            // 
            this.listViewMembers.HideSelection = false;
            this.listViewMembers.Location = new System.Drawing.Point(68, 322);
            this.listViewMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMembers.Name = "listViewMembers";
            this.listViewMembers.Size = new System.Drawing.Size(1075, 321);
            this.listViewMembers.TabIndex = 4;
            this.listViewMembers.UseCompatibleStateImageBehavior = false;
            // 
            // buttonProgress
            // 
            this.buttonProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgress.Location = new System.Drawing.Point(577, 72);
            this.buttonProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProgress.Name = "buttonProgress";
            this.buttonProgress.Size = new System.Drawing.Size(150, 50);
            this.buttonProgress.TabIndex = 8;
            this.buttonProgress.Text = "Progress";
            this.buttonProgress.UseVisualStyleBackColor = true;
            // 
            // TrainerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.buttonProgress);
            this.Controls.Add(this.labelTrainerText);
            this.Controls.Add(this.buttonLocations);
            this.Controls.Add(this.buttonActivities);
            this.Controls.Add(this.listViewMembers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrainerMenu";
            this.Text = "TrainerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrainerText;
        private System.Windows.Forms.Button buttonLocations;
        private System.Windows.Forms.Button buttonActivities;
        private System.Windows.Forms.ListView listViewMembers;
        private System.Windows.Forms.Button buttonProgress;
    }
}
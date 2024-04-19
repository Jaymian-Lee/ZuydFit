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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerMenu));
            this.labelTrainerText = new System.Windows.Forms.Label();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.listViewMembers = new System.Windows.Forms.ListView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTrainerText
            // 
            this.labelTrainerText.AutoSize = true;
            this.labelTrainerText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainerText.ForeColor = System.Drawing.Color.White;
            this.labelTrainerText.Location = new System.Drawing.Point(39, 38);
            this.labelTrainerText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrainerText.Name = "labelTrainerText";
            this.labelTrainerText.Size = new System.Drawing.Size(115, 35);
            this.labelTrainerText.TabIndex = 7;
            this.labelTrainerText.Text = "Trainer";
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(520, 46);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(100, 32);
            this.btnLocations.TabIndex = 2;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.Location = new System.Drawing.Point(656, 46);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(100, 32);
            this.btnActivities.TabIndex = 3;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // listViewMembers
            // 
            this.listViewMembers.HideSelection = false;
            this.listViewMembers.Location = new System.Drawing.Point(45, 206);
            this.listViewMembers.Name = "listViewMembers";
            this.listViewMembers.Size = new System.Drawing.Size(718, 207);
            this.listViewMembers.TabIndex = 5;
            this.listViewMembers.UseCompatibleStateImageBehavior = false;
            this.listViewMembers.SelectedIndexChanged += new System.EventHandler(this.listViewMembers_SelectedIndexChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(45, 76);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "All members";
            // 
            // TrainerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelTrainerText);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.listViewMembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainerMenu";
            this.Text = "TrainerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrainerText;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.ListView listViewMembers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}
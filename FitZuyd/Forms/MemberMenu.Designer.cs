namespace FitZuyd.Forms
{
    partial class MemberMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberMenu));
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.labelMemberText = new System.Windows.Forms.Label();
            this.progressBarMember = new System.Windows.Forms.ProgressBar();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFinishActivities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewActivities
            // 
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(40, 206);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(575, 207);
            this.listViewActivities.TabIndex = 0;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.SelectedIndexChanged += new System.EventHandler(this.listViewActivities_SelectedIndexChanged);
            // 
            // btnActivities
            // 
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.Location = new System.Drawing.Point(651, 46);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(100, 32);
            this.btnActivities.TabIndex = 1;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(515, 46);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(100, 32);
            this.btnLocations.TabIndex = 2;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // labelMemberText
            // 
            this.labelMemberText.AutoSize = true;
            this.labelMemberText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberText.ForeColor = System.Drawing.Color.White;
            this.labelMemberText.Location = new System.Drawing.Point(33, 38);
            this.labelMemberText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberText.Name = "labelMemberText";
            this.labelMemberText.Size = new System.Drawing.Size(130, 35);
            this.labelMemberText.TabIndex = 3;
            this.labelMemberText.Text = "Member";
            // 
            // progressBarMember
            // 
            this.progressBarMember.Location = new System.Drawing.Point(40, 148);
            this.progressBarMember.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarMember.Name = "progressBarMember";
            this.progressBarMember.Size = new System.Drawing.Size(711, 29);
            this.progressBarMember.TabIndex = 4;
            this.progressBarMember.Value = 10;
            this.progressBarMember.Click += new System.EventHandler(this.progressBarMember_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(39, 76);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 32);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFinishActivities
            // 
            this.btnFinishActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishActivities.Location = new System.Drawing.Point(651, 206);
            this.btnFinishActivities.Name = "btnFinishActivities";
            this.btnFinishActivities.Size = new System.Drawing.Size(100, 32);
            this.btnFinishActivities.TabIndex = 8;
            this.btnFinishActivities.Text = "Afronden";
            this.btnFinishActivities.UseVisualStyleBackColor = true;
            this.btnFinishActivities.Click += new System.EventHandler(this.btnFinishActivities_Click);
            // 
            // MemberMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinishActivities);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.progressBarMember);
            this.Controls.Add(this.labelMemberText);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.listViewActivities);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberMenu";
            this.Text = "MemberMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Label labelMemberText;
        private System.Windows.Forms.ProgressBar progressBarMember;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFinishActivities;
    }
}
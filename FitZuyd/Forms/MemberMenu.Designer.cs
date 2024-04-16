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
            this.SuspendLayout();
            // 
            // listViewActivities
            // 
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(60, 322);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(1075, 321);
            this.listViewActivities.TabIndex = 0;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            // 
            // btnActivities
            // 
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.Location = new System.Drawing.Point(976, 72);
            this.btnActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(150, 50);
            this.btnActivities.TabIndex = 1;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(772, 72);
            this.btnLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(150, 50);
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
            this.labelMemberText.Location = new System.Drawing.Point(50, 60);
            this.labelMemberText.Name = "labelMemberText";
            this.labelMemberText.Size = new System.Drawing.Size(210, 56);
            this.labelMemberText.TabIndex = 3;
            this.labelMemberText.Text = "Member";
            // 
            // progressBarMember
            // 
            this.progressBarMember.Location = new System.Drawing.Point(60, 232);
            this.progressBarMember.Name = "progressBarMember";
            this.progressBarMember.Size = new System.Drawing.Size(1066, 46);
            this.progressBarMember.TabIndex = 4;
            this.progressBarMember.Value = 10;
            // 
            // MemberMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.progressBarMember);
            this.Controls.Add(this.labelMemberText);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.listViewActivities);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}
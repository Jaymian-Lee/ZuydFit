namespace FitZuyd.Forms
{
    partial class MemberActivtity
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
            this.labelMemberText = new System.Windows.Forms.Label();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.btnParticipate = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMemberText
            // 
            this.labelMemberText.AutoSize = true;
            this.labelMemberText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberText.ForeColor = System.Drawing.Color.White;
            this.labelMemberText.Location = new System.Drawing.Point(42, 55);
            this.labelMemberText.Name = "labelMemberText";
            this.labelMemberText.Size = new System.Drawing.Size(210, 56);
            this.labelMemberText.TabIndex = 8;
            this.labelMemberText.Text = "Member";
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(764, 67);
            this.btnLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(150, 50);
            this.btnLocations.TabIndex = 7;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            // 
            // btnActivities
            // 
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.Location = new System.Drawing.Point(968, 67);
            this.btnActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(150, 50);
            this.btnActivities.TabIndex = 6;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = true;
            // 
            // listViewActivities
            // 
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(52, 172);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(862, 466);
            this.listViewActivities.TabIndex = 5;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            // 
            // btnParticipate
            // 
            this.btnParticipate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipate.Location = new System.Drawing.Point(968, 172);
            this.btnParticipate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParticipate.Name = "btnParticipate";
            this.btnParticipate.Size = new System.Drawing.Size(150, 50);
            this.btnParticipate.TabIndex = 9;
            this.btnParticipate.Text = "Participate";
            this.btnParticipate.UseVisualStyleBackColor = true;
            // 
            // btnLeave
            // 
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Location = new System.Drawing.Point(968, 273);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(150, 50);
            this.btnLeave.TabIndex = 10;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(968, 588);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // MemberActivtity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1169, 693);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnParticipate);
            this.Controls.Add(this.labelMemberText);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.listViewActivities);
            this.Name = "MemberActivtity";
            this.Text = "MemberActivtity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMemberText;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Button btnParticipate;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnClose;
    }
}
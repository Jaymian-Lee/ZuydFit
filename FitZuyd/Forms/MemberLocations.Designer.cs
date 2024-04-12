namespace FitZuyd.Forms
{
    partial class MemberLocations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLocations));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.labelMemberText = new System.Windows.Forms.Label();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(938, 591);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(938, 175);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(150, 50);
            this.btnDetails.TabIndex = 16;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // labelMemberText
            // 
            this.labelMemberText.AutoSize = true;
            this.labelMemberText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberText.ForeColor = System.Drawing.Color.White;
            this.labelMemberText.Location = new System.Drawing.Point(12, 58);
            this.labelMemberText.Name = "labelMemberText";
            this.labelMemberText.Size = new System.Drawing.Size(210, 56);
            this.labelMemberText.TabIndex = 15;
            this.labelMemberText.Text = "Member";
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(734, 70);
            this.btnLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(150, 50);
            this.btnLocations.TabIndex = 14;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.Location = new System.Drawing.Point(938, 70);
            this.btnActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(150, 50);
            this.btnActivities.TabIndex = 13;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // listViewActivities
            // 
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(22, 175);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(862, 466);
            this.listViewActivities.TabIndex = 12;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            // 
            // MemberLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1100, 698);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.labelMemberText);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.listViewActivities);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberLocations";
            this.Text = "MemberLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label labelMemberText;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.ListView listViewActivities;
    }
}
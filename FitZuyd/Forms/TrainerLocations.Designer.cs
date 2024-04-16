namespace FitZuyd.Forms
{
    partial class TrainerLocations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerLocations));
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelMemberText = new System.Windows.Forms.Label();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.listViewTLocation = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnMembers
            // 
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Location = new System.Drawing.Point(361, 45);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(100, 32);
            this.btnMembers.TabIndex = 31;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(631, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(631, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(631, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(631, 113);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 32);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelMemberText
            // 
            this.labelMemberText.AutoSize = true;
            this.labelMemberText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberText.ForeColor = System.Drawing.Color.White;
            this.labelMemberText.Location = new System.Drawing.Point(13, 38);
            this.labelMemberText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberText.Name = "labelMemberText";
            this.labelMemberText.Size = new System.Drawing.Size(139, 35);
            this.labelMemberText.TabIndex = 25;
            this.labelMemberText.Text = "Location";
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(495, 45);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(100, 32);
            this.btnLocations.TabIndex = 24;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.Location = new System.Drawing.Point(631, 45);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(100, 32);
            this.btnActivities.TabIndex = 23;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // listViewTLocation
            // 
            this.listViewTLocation.HideSelection = false;
            this.listViewTLocation.Location = new System.Drawing.Point(20, 113);
            this.listViewTLocation.Name = "listViewTLocation";
            this.listViewTLocation.Size = new System.Drawing.Size(576, 300);
            this.listViewTLocation.TabIndex = 22;
            this.listViewTLocation.UseCompatibleStateImageBehavior = false;
            // 
            // TrainerLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(745, 448);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelMemberText);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.listViewTLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TrainerLocations";
            this.Text = "TrainerLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelMemberText;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.ListView listViewTLocation;
    }
}
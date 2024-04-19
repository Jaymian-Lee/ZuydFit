namespace FitZuyd.Forms
{
    partial class TrainerActivityCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerActivityCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose_location = new System.Windows.Forms.Button();
            this.ActivityPoints = new System.Windows.Forms.Label();
            this.LocationName = new System.Windows.Forms.Label();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelActivity = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.LocationIdLbl = new System.Windows.Forms.Label();
            this.textBoxLocationId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Create";
            // 
            // btnClose_location
            // 
            this.btnClose_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_location.Location = new System.Drawing.Point(246, 290);
            this.btnClose_location.Name = "btnClose_location";
            this.btnClose_location.Size = new System.Drawing.Size(100, 32);
            this.btnClose_location.TabIndex = 49;
            this.btnClose_location.Text = "Close";
            this.btnClose_location.UseVisualStyleBackColor = true;
            this.btnClose_location.Click += new System.EventHandler(this.btnClose_location_Click);
            // 
            // ActivityPoints
            // 
            this.ActivityPoints.AutoSize = true;
            this.ActivityPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityPoints.ForeColor = System.Drawing.Color.White;
            this.ActivityPoints.Location = new System.Drawing.Point(48, 181);
            this.ActivityPoints.Name = "ActivityPoints";
            this.ActivityPoints.Size = new System.Drawing.Size(44, 16);
            this.ActivityPoints.TabIndex = 48;
            this.ActivityPoints.Text = "Points";
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationName.ForeColor = System.Drawing.Color.White;
            this.LocationName.Location = new System.Drawing.Point(48, 133);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(44, 16);
            this.LocationName.TabIndex = 47;
            this.LocationName.Text = "Name";
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(51, 200);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(295, 22);
            this.textBoxPoints.TabIndex = 46;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(51, 152);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(295, 22);
            this.textBoxName.TabIndex = 45;
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivity.ForeColor = System.Drawing.Color.White;
            this.labelActivity.Location = new System.Drawing.Point(45, 63);
            this.labelActivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(122, 35);
            this.labelActivity.TabIndex = 44;
            this.labelActivity.Text = "Activity";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(51, 290);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 32);
            this.btnCreate.TabIndex = 43;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // LocationIdLbl
            // 
            this.LocationIdLbl.AutoSize = true;
            this.LocationIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationIdLbl.ForeColor = System.Drawing.Color.White;
            this.LocationIdLbl.Location = new System.Drawing.Point(48, 225);
            this.LocationIdLbl.Name = "LocationIdLbl";
            this.LocationIdLbl.Size = new System.Drawing.Size(69, 16);
            this.LocationIdLbl.TabIndex = 52;
            this.LocationIdLbl.Text = "LocationId";
            // 
            // textBoxLocationId
            // 
            this.textBoxLocationId.Location = new System.Drawing.Point(51, 244);
            this.textBoxLocationId.Name = "textBoxLocationId";
            this.textBoxLocationId.Size = new System.Drawing.Size(295, 22);
            this.textBoxLocationId.TabIndex = 51;
            // 
            // TrainerActivityCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.LocationIdLbl);
            this.Controls.Add(this.textBoxLocationId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose_location);
            this.Controls.Add(this.ActivityPoints);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainerActivityCreate";
            this.Text = "TrainerActivityCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose_location;
        private System.Windows.Forms.Label ActivityPoints;
        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label LocationIdLbl;
        private System.Windows.Forms.TextBox textBoxLocationId;
    }
}
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
            this.btnClose = new System.Windows.Forms.Button();
            this.LocationId = new System.Windows.Forms.Label();
            this.ActivityPointsLbl = new System.Windows.Forms.Label();
            this.textBoxLocationId = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.labelActivity = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Create";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(226, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LocationId
            // 
            this.LocationId.AutoSize = true;
            this.LocationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationId.ForeColor = System.Drawing.Color.White;
            this.LocationId.Location = new System.Drawing.Point(28, 194);
            this.LocationId.Name = "LocationId";
            this.LocationId.Size = new System.Drawing.Size(69, 16);
            this.LocationId.TabIndex = 48;
            this.LocationId.Text = "LocationId";
            // 
            // ActivityPointsLbl
            // 
            this.ActivityPointsLbl.AutoSize = true;
            this.ActivityPointsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityPointsLbl.ForeColor = System.Drawing.Color.White;
            this.ActivityPointsLbl.Location = new System.Drawing.Point(28, 146);
            this.ActivityPointsLbl.Name = "ActivityPointsLbl";
            this.ActivityPointsLbl.Size = new System.Drawing.Size(44, 16);
            this.ActivityPointsLbl.TabIndex = 47;
            this.ActivityPointsLbl.Text = "Points";
            // 
            // textBoxLocationId
            // 
            this.textBoxLocationId.Location = new System.Drawing.Point(31, 213);
            this.textBoxLocationId.Name = "textBoxLocationId";
            this.textBoxLocationId.Size = new System.Drawing.Size(295, 22);
            this.textBoxLocationId.TabIndex = 46;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(31, 165);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(295, 22);
            this.textBoxPoints.TabIndex = 45;
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivity.ForeColor = System.Drawing.Color.White;
            this.labelActivity.Location = new System.Drawing.Point(25, 43);
            this.labelActivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(122, 35);
            this.labelActivity.TabIndex = 44;
            this.labelActivity.Text = "Activity";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(31, 270);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 32);
            this.btnCreate.TabIndex = 43;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(31, 121);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(295, 22);
            this.textBoxName.TabIndex = 51;
            // 
            // TrainerActivityCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LocationId);
            this.Controls.Add(this.ActivityPointsLbl);
            this.Controls.Add(this.textBoxLocationId);
            this.Controls.Add(this.textBoxPoints);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label LocationId;
        private System.Windows.Forms.Label ActivityPointsLbl;
        private System.Windows.Forms.TextBox textBoxLocationId;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
    }
}
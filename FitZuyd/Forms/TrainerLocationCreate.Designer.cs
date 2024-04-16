namespace FitZuyd.Forms
{
    partial class TrainerLocationCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerLocationCreate));
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelLocationText = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.LocationName = new System.Windows.Forms.Label();
            this.LocationAdress = new System.Windows.Forms.Label();
            this.btnClose_location = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(50, 275);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 32);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelLocationText
            // 
            this.labelLocationText.AutoSize = true;
            this.labelLocationText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationText.ForeColor = System.Drawing.Color.White;
            this.labelLocationText.Location = new System.Drawing.Point(44, 48);
            this.labelLocationText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocationText.Name = "labelLocationText";
            this.labelLocationText.Size = new System.Drawing.Size(139, 35);
            this.labelLocationText.TabIndex = 34;
            this.labelLocationText.Text = "Location";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(50, 170);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(295, 22);
            this.textBoxName.TabIndex = 35;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(50, 218);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(295, 22);
            this.textBoxAdress.TabIndex = 36;
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationName.ForeColor = System.Drawing.Color.White;
            this.LocationName.Location = new System.Drawing.Point(47, 151);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(44, 16);
            this.LocationName.TabIndex = 37;
            this.LocationName.Text = "Name";
            // 
            // LocationAdress
            // 
            this.LocationAdress.AutoSize = true;
            this.LocationAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationAdress.ForeColor = System.Drawing.Color.White;
            this.LocationAdress.Location = new System.Drawing.Point(47, 199);
            this.LocationAdress.Name = "LocationAdress";
            this.LocationAdress.Size = new System.Drawing.Size(50, 16);
            this.LocationAdress.TabIndex = 38;
            this.LocationAdress.Text = "Adress";
            // 
            // btnClose_location
            // 
            this.btnClose_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_location.Location = new System.Drawing.Point(245, 275);
            this.btnClose_location.Name = "btnClose_location";
            this.btnClose_location.Size = new System.Drawing.Size(100, 32);
            this.btnClose_location.TabIndex = 41;
            this.btnClose_location.Text = "Close";
            this.btnClose_location.UseVisualStyleBackColor = true;
            this.btnClose_location.Click += new System.EventHandler(this.btnClose_location_Click);
            // 
            // TrainerLocationCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.btnClose_location);
            this.Controls.Add(this.LocationAdress);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelLocationText);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainerLocationCreate";
            this.Text = "TrainerLocationCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelLocationText;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.Label LocationAdress;
        private System.Windows.Forms.Button btnClose_location;
    }
}
namespace FitZuyd.Forms
{
    partial class TrainerActivityDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerActivityDelete));
            this.IdLbl = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelActivity = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.ForeColor = System.Drawing.Color.White;
            this.IdLbl.Location = new System.Drawing.Point(31, 164);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(20, 16);
            this.IdLbl.TabIndex = 66;
            this.IdLbl.Text = "ID";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(34, 183);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(295, 22);
            this.TextBoxId.TabIndex = 65;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelDelete.ForeColor = System.Drawing.Color.White;
            this.labelDelete.Location = new System.Drawing.Point(30, 79);
            this.labelDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(69, 24);
            this.labelDelete.TabIndex = 64;
            this.labelDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(229, 286);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivity.ForeColor = System.Drawing.Color.White;
            this.labelActivity.Location = new System.Drawing.Point(28, 44);
            this.labelActivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(122, 35);
            this.labelActivity.TabIndex = 58;
            this.labelActivity.Text = "Activity";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(34, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // TrainerActivityDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainerActivityDelete";
            this.Text = "TrainerActivityDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.Button btnDelete;
    }
}
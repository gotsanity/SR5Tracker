namespace SR5Tracker
{
    partial class CharacterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhysLabel = new System.Windows.Forms.Label();
            this.lblStunLabel = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblStun = new System.Windows.Forms.Label();
            this.lblPhys = new System.Windows.Forms.Label();
            this.btnModifyHealth = new System.Windows.Forms.Button();
            this.btnAddInit = new System.Windows.Forms.Button();
            this.btnEditInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(282, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Custom Name of Significant Length";
            // 
            // lblPhysLabel
            // 
            this.lblPhysLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhysLabel.AutoSize = true;
            this.lblPhysLabel.Location = new System.Drawing.Point(5, 40);
            this.lblPhysLabel.Name = "lblPhysLabel";
            this.lblPhysLabel.Size = new System.Drawing.Size(32, 15);
            this.lblPhysLabel.TabIndex = 1;
            this.lblPhysLabel.Text = "Phys";
            // 
            // lblStunLabel
            // 
            this.lblStunLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStunLabel.AutoSize = true;
            this.lblStunLabel.Location = new System.Drawing.Point(5, 25);
            this.lblStunLabel.Name = "lblStunLabel";
            this.lblStunLabel.Size = new System.Drawing.Size(31, 15);
            this.lblStunLabel.TabIndex = 4;
            this.lblStunLabel.Text = "Stun";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(349, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(20, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblStun
            // 
            this.lblStun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStun.AutoSize = true;
            this.lblStun.Location = new System.Drawing.Point(45, 25);
            this.lblStun.Name = "lblStun";
            this.lblStun.Size = new System.Drawing.Size(13, 15);
            this.lblStun.TabIndex = 12;
            this.lblStun.Text = "0";
            // 
            // lblPhys
            // 
            this.lblPhys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhys.AutoSize = true;
            this.lblPhys.Location = new System.Drawing.Point(45, 40);
            this.lblPhys.Name = "lblPhys";
            this.lblPhys.Size = new System.Drawing.Size(13, 15);
            this.lblPhys.TabIndex = 11;
            this.lblPhys.Text = "0";
            // 
            // btnModifyHealth
            // 
            this.btnModifyHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyHealth.Location = new System.Drawing.Point(113, 32);
            this.btnModifyHealth.Name = "btnModifyHealth";
            this.btnModifyHealth.Size = new System.Drawing.Size(75, 23);
            this.btnModifyHealth.TabIndex = 13;
            this.btnModifyHealth.Text = "Edit Health";
            this.btnModifyHealth.UseVisualStyleBackColor = true;
            this.btnModifyHealth.Click += new System.EventHandler(this.btnModifyHealth_Click);
            // 
            // btnAddInit
            // 
            this.btnAddInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInit.Location = new System.Drawing.Point(284, 32);
            this.btnAddInit.Name = "btnAddInit";
            this.btnAddInit.Size = new System.Drawing.Size(85, 23);
            this.btnAddInit.TabIndex = 14;
            this.btnAddInit.Text = "Add Initiative";
            this.btnAddInit.UseVisualStyleBackColor = true;
            this.btnAddInit.Click += new System.EventHandler(this.btnAddInit_Click);
            // 
            // btnEditInit
            // 
            this.btnEditInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInit.Location = new System.Drawing.Point(194, 32);
            this.btnEditInit.Name = "btnEditInit";
            this.btnEditInit.Size = new System.Drawing.Size(84, 23);
            this.btnEditInit.TabIndex = 15;
            this.btnEditInit.Text = "Edit Initiative";
            this.btnEditInit.UseVisualStyleBackColor = true;
            this.btnEditInit.Click += new System.EventHandler(this.btnEditInit_Click);
            // 
            // CharacterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnEditInit);
            this.Controls.Add(this.btnAddInit);
            this.Controls.Add(this.btnModifyHealth);
            this.Controls.Add(this.lblStun);
            this.Controls.Add(this.lblPhys);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblStunLabel);
            this.Controls.Add(this.lblPhysLabel);
            this.Controls.Add(this.lblName);
            this.Name = "CharacterControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(372, 60);
            this.Load += new System.EventHandler(this.CharacterControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblPhysLabel;
        private Label lblStunLabel;
        private Button btnRemove;
        private Label lblStun;
        private Label lblPhys;
        private Button btnModifyHealth;
        private Button btnAddInit;
        private Button btnEditInit;
    }
}

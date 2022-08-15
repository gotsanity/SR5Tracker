namespace SR5Tracker
{
    partial class EditHealthForm
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
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.numChange = new System.Windows.Forms.NumericUpDown();
            this.btnApplyStun = new System.Windows.Forms.Button();
            this.lblCurrentTitle = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.btnClearStun = new System.Windows.Forms.Button();
            this.rbStun = new System.Windows.Forms.RadioButton();
            this.rbPhysical = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(33, 76);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(48, 15);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "Change";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(101, 99);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(13, 15);
            this.lblTotalValue.TabIndex = 17;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Location = new System.Drawing.Point(33, 99);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(59, 15);
            this.lblTotalTitle.TabIndex = 18;
            this.lblTotalTitle.Text = "New Total";
            // 
            // numChange
            // 
            this.numChange.AutoSize = true;
            this.numChange.Location = new System.Drawing.Point(101, 72);
            this.numChange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numChange.Name = "numChange";
            this.numChange.Size = new System.Drawing.Size(68, 23);
            this.numChange.TabIndex = 16;
            this.numChange.ValueChanged += new System.EventHandler(this.UpdateValues);
            // 
            // btnApplyStun
            // 
            this.btnApplyStun.Location = new System.Drawing.Point(20, 131);
            this.btnApplyStun.Name = "btnApplyStun";
            this.btnApplyStun.Size = new System.Drawing.Size(75, 23);
            this.btnApplyStun.TabIndex = 12;
            this.btnApplyStun.Text = "Apply";
            this.btnApplyStun.UseVisualStyleBackColor = true;
            this.btnApplyStun.Click += new System.EventHandler(this.btnApplyStun_Click);
            // 
            // lblCurrentTitle
            // 
            this.lblCurrentTitle.AutoSize = true;
            this.lblCurrentTitle.Location = new System.Drawing.Point(33, 53);
            this.lblCurrentTitle.Name = "lblCurrentTitle";
            this.lblCurrentTitle.Size = new System.Drawing.Size(47, 15);
            this.lblCurrentTitle.TabIndex = 11;
            this.lblCurrentTitle.Text = "Current";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(101, 53);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(13, 15);
            this.lblCurrentValue.TabIndex = 14;
            this.lblCurrentValue.Text = "0";
            // 
            // btnClearStun
            // 
            this.btnClearStun.Location = new System.Drawing.Point(101, 131);
            this.btnClearStun.Name = "btnClearStun";
            this.btnClearStun.Size = new System.Drawing.Size(78, 23);
            this.btnClearStun.TabIndex = 13;
            this.btnClearStun.Text = "Clear";
            this.btnClearStun.UseVisualStyleBackColor = true;
            // 
            // rbStun
            // 
            this.rbStun.AutoSize = true;
            this.rbStun.Checked = true;
            this.rbStun.Location = new System.Drawing.Point(33, 30);
            this.rbStun.Name = "rbStun";
            this.rbStun.Size = new System.Drawing.Size(49, 19);
            this.rbStun.TabIndex = 19;
            this.rbStun.TabStop = true;
            this.rbStun.Text = "Stun";
            this.rbStun.UseVisualStyleBackColor = true;
            this.rbStun.CheckedChanged += new System.EventHandler(this.UpdateValues);
            // 
            // rbPhysical
            // 
            this.rbPhysical.AutoSize = true;
            this.rbPhysical.Location = new System.Drawing.Point(101, 30);
            this.rbPhysical.Name = "rbPhysical";
            this.rbPhysical.Size = new System.Drawing.Size(68, 19);
            this.rbPhysical.TabIndex = 20;
            this.rbPhysical.Text = "Physical";
            this.rbPhysical.UseVisualStyleBackColor = true;
            this.rbPhysical.CheckedChanged += new System.EventHandler(this.UpdateValues);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(0, 4);
            this.lblName.MinimumSize = new System.Drawing.Size(204, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(204, 17);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "This is the name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditHealthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 165);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotalTitle);
            this.Controls.Add(this.numChange);
            this.Controls.Add(this.btnApplyStun);
            this.Controls.Add(this.lblCurrentTitle);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.btnClearStun);
            this.Controls.Add(this.rbStun);
            this.Controls.Add(this.rbPhysical);
            this.Name = "EditHealthForm";
            this.Text = "EditHealthForm";
            this.Load += new System.EventHandler(this.EditHealthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblChange;
        private Label lblTotalValue;
        private Label lblTotalTitle;
        private NumericUpDown numChange;
        private Button btnApplyStun;
        private Label lblCurrentTitle;
        private Label lblCurrentValue;
        private Button btnClearStun;
        private RadioButton rbStun;
        private RadioButton rbPhysical;
        private Label lblName;
    }
}
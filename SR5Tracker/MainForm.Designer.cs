namespace SR5Tracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numStun = new System.Windows.Forms.NumericUpDown();
            this.numPhys = new System.Windows.Forms.NumericUpDown();
            this.lblStun = new System.Windows.Forms.Label();
            this.lblPhys = new System.Windows.Forms.Label();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtNewCharacter = new System.Windows.Forms.TextBox();
            this.flowCharacters = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEndPass = new System.Windows.Forms.Button();
            this.btnEndCombat = new System.Windows.Forms.Button();
            this.gridCombat = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCombat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numStun);
            this.groupBox2.Controls.Add(this.numPhys);
            this.groupBox2.Controls.Add(this.lblStun);
            this.groupBox2.Controls.Add(this.lblPhys);
            this.groupBox2.Controls.Add(this.lblAddNew);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.txtNewCharacter);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a new character";
            // 
            // numStun
            // 
            this.numStun.Location = new System.Drawing.Point(377, 24);
            this.numStun.Name = "numStun";
            this.numStun.Size = new System.Drawing.Size(42, 23);
            this.numStun.TabIndex = 7;
            // 
            // numPhys
            // 
            this.numPhys.Location = new System.Drawing.Point(292, 24);
            this.numPhys.Name = "numPhys";
            this.numPhys.Size = new System.Drawing.Size(42, 23);
            this.numPhys.TabIndex = 0;
            // 
            // lblStun
            // 
            this.lblStun.AutoSize = true;
            this.lblStun.Location = new System.Drawing.Point(337, 28);
            this.lblStun.Name = "lblStun";
            this.lblStun.Size = new System.Drawing.Size(34, 15);
            this.lblStun.TabIndex = 6;
            this.lblStun.Text = "Stun:";
            // 
            // lblPhys
            // 
            this.lblPhys.AutoSize = true;
            this.lblPhys.Location = new System.Drawing.Point(253, 28);
            this.lblPhys.Name = "lblPhys";
            this.lblPhys.Size = new System.Drawing.Size(35, 15);
            this.lblPhys.TabIndex = 4;
            this.lblPhys.Text = "Phys:";
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Location = new System.Drawing.Point(6, 28);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(42, 15);
            this.lblAddNew.TabIndex = 2;
            this.lblAddNew.Text = "Name:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(421, 24);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(112, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtNewCharacter
            // 
            this.txtNewCharacter.Location = new System.Drawing.Point(54, 24);
            this.txtNewCharacter.Name = "txtNewCharacter";
            this.txtNewCharacter.Size = new System.Drawing.Size(193, 23);
            this.txtNewCharacter.TabIndex = 0;
            // 
            // flowCharacters
            // 
            this.flowCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowCharacters.AutoScroll = true;
            this.flowCharacters.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.flowCharacters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowCharacters.Location = new System.Drawing.Point(12, 72);
            this.flowCharacters.MinimumSize = new System.Drawing.Size(400, 366);
            this.flowCharacters.Name = "flowCharacters";
            this.flowCharacters.Size = new System.Drawing.Size(400, 366);
            this.flowCharacters.TabIndex = 2;
            this.flowCharacters.WrapContents = false;
            // 
            // btnEndPass
            // 
            this.btnEndPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndPass.Location = new System.Drawing.Point(418, 415);
            this.btnEndPass.Name = "btnEndPass";
            this.btnEndPass.Size = new System.Drawing.Size(114, 23);
            this.btnEndPass.TabIndex = 4;
            this.btnEndPass.Text = "End Init Pass";
            this.btnEndPass.UseVisualStyleBackColor = true;
            this.btnEndPass.Click += new System.EventHandler(this.btnEndPass_Click);
            // 
            // btnEndCombat
            // 
            this.btnEndCombat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndCombat.Location = new System.Drawing.Point(687, 415);
            this.btnEndCombat.Name = "btnEndCombat";
            this.btnEndCombat.Size = new System.Drawing.Size(109, 23);
            this.btnEndCombat.TabIndex = 5;
            this.btnEndCombat.Text = "Start Combat";
            this.btnEndCombat.UseVisualStyleBackColor = true;
            this.btnEndCombat.Click += new System.EventHandler(this.btnEndCombat_Click);
            // 
            // gridCombat
            // 
            this.gridCombat.AllowUserToAddRows = false;
            this.gridCombat.AllowUserToDeleteRows = false;
            this.gridCombat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCombat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCombat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCombat.Location = new System.Drawing.Point(418, 72);
            this.gridCombat.MinimumSize = new System.Drawing.Size(378, 337);
            this.gridCombat.Name = "gridCombat";
            this.gridCombat.ReadOnly = true;
            this.gridCombat.RowHeadersVisible = false;
            this.gridCombat.RowTemplate.Height = 25;
            this.gridCombat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCombat.Size = new System.Drawing.Size(378, 337);
            this.gridCombat.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridCombat);
            this.Controls.Add(this.btnEndCombat);
            this.Controls.Add(this.btnEndPass);
            this.Controls.Add(this.flowCharacters);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "SR5 Tracker";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCombat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private NumericUpDown numStun;
        private NumericUpDown numPhys;
        private Label lblStun;
        private Label lblPhys;
        private Label lblAddNew;
        private Button btnAddNew;
        private TextBox txtNewCharacter;
        private FlowLayoutPanel flowCharacters;
        private Button btnEndPass;
        private Button btnEndCombat;
        private DataGridView gridCombat;
    }
}
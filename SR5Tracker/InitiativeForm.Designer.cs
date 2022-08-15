namespace SR5Tracker
{
    partial class InitiativeForm
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
            this.grpInitiative = new System.Windows.Forms.GroupBox();
            this.rbAstral = new System.Windows.Forms.RadioButton();
            this.rbMatrix = new System.Windows.Forms.RadioButton();
            this.rbPhysical = new System.Windows.Forms.RadioButton();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.numRoll = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpInitiative.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoll)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInitiative
            // 
            this.grpInitiative.Controls.Add(this.rbAstral);
            this.grpInitiative.Controls.Add(this.rbMatrix);
            this.grpInitiative.Controls.Add(this.rbPhysical);
            this.grpInitiative.Location = new System.Drawing.Point(12, 29);
            this.grpInitiative.Name = "grpInitiative";
            this.grpInitiative.Size = new System.Drawing.Size(241, 53);
            this.grpInitiative.TabIndex = 0;
            this.grpInitiative.TabStop = false;
            this.grpInitiative.Text = "Initiative Type";
            // 
            // rbAstral
            // 
            this.rbAstral.AutoSize = true;
            this.rbAstral.Location = new System.Drawing.Point(180, 22);
            this.rbAstral.Name = "rbAstral";
            this.rbAstral.Size = new System.Drawing.Size(55, 19);
            this.rbAstral.TabIndex = 2;
            this.rbAstral.Text = "Astral";
            this.rbAstral.UseVisualStyleBackColor = true;
            // 
            // rbMatrix
            // 
            this.rbMatrix.AutoSize = true;
            this.rbMatrix.Location = new System.Drawing.Point(97, 22);
            this.rbMatrix.Name = "rbMatrix";
            this.rbMatrix.Size = new System.Drawing.Size(59, 19);
            this.rbMatrix.TabIndex = 1;
            this.rbMatrix.Text = "Matrix";
            this.rbMatrix.UseVisualStyleBackColor = true;
            // 
            // rbPhysical
            // 
            this.rbPhysical.AutoSize = true;
            this.rbPhysical.Checked = true;
            this.rbPhysical.Location = new System.Drawing.Point(6, 22);
            this.rbPhysical.Name = "rbPhysical";
            this.rbPhysical.Size = new System.Drawing.Size(68, 19);
            this.rbPhysical.TabIndex = 0;
            this.rbPhysical.TabStop = true;
            this.rbPhysical.Text = "Physical";
            this.rbPhysical.UseVisualStyleBackColor = true;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(79, 9);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(112, 15);
            this.lblCharacterName.TabIndex = 3;
            this.lblCharacterName.Text = "Unknown Character";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(12, 9);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(61, 15);
            this.lblCharacter.TabIndex = 2;
            this.lblCharacter.Text = "Character:";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(80, 94);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(30, 15);
            this.lblRoll.TabIndex = 4;
            this.lblRoll.Text = "Roll:";
            // 
            // numRoll
            // 
            this.numRoll.Location = new System.Drawing.Point(118, 90);
            this.numRoll.Name = "numRoll";
            this.numRoll.Size = new System.Drawing.Size(62, 23);
            this.numRoll.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(57, 123);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InitiativeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 154);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numRoll);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.grpInitiative);
            this.Name = "InitiativeForm";
            this.Text = "Modify Initiative";
            this.Load += new System.EventHandler(this.InitiativeForm_Load);
            this.grpInitiative.ResumeLayout(false);
            this.grpInitiative.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpInitiative;
        private RadioButton rbAstral;
        private RadioButton rbMatrix;
        private RadioButton rbPhysical;
        private Label lblCharacterName;
        private Label lblCharacter;
        private Label lblRoll;
        private NumericUpDown numRoll;
        private Button btnOk;
        private Button btnCancel;
    }
}
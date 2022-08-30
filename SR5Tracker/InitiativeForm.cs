using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR5Tracker
{
    public partial class InitiativeForm : Form
    {
        public InitiativeType InitiativeType { get; set; }
        public int InitiativeValue { get; set; }
        public Character Character { get; set; }

        public InitiativeForm(Character character)
        {
            Character = character;
            InitializeComponent();
        }

        public void SetExisting(Initiative values)
        {
            switch (values.Type)
            {
                case InitiativeType.Physical:
                    rbPhysical.Checked = true; break;
                case InitiativeType.Matrix:
                    rbMatrix.Checked = true; break;
                default:
                    rbAstral.Checked = true; break;
            }

            numRoll.Value = values.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbPhysical.Checked)
            {
                InitiativeType = InitiativeType.Physical;
            }
            else if (rbMatrix.Checked)
            {
                InitiativeType = InitiativeType.Matrix;
            }
            else if (rbAstral.Checked)
            {
                InitiativeType = InitiativeType.Astral;
            }
            else
            {
                InitiativeType = InitiativeType.None;
            }

            InitiativeValue = (int) numRoll.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitiativeForm_Load(object sender, EventArgs e)
        {
            lblCharacterName.Text = Character.Name;
        }

        private void OnEnterKeypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk_Click(sender, e);
            }
        }
    }
}

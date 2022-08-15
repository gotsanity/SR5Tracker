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
    public partial class EditHealthForm : Form
    {
        public Character _character;

        public EditHealthForm(Character character)
        {
            _character = character;
            InitializeComponent();
        }

        private void EditHealthForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edit " + _character.Name + "'s Health";
            lblName.Text = _character.Name;
            lblCurrentValue.Text = _character.StunHealth.ToString();
            lblTotalValue.Text = _character.StunHealth.ToString();
        }

        private void UpdateValues(object sender, EventArgs e)
        {
            if (rbStun.Checked)
            {
                DisplayCalc(_character.StunHealth, _character.StunHealthMax);
            }
            else
            {
                DisplayCalc(_character.PhysicalHealth, _character.PhysicalHealthMax);
            }
        }

        private void DisplayCalc(int baseValue, int max)
        {
            lblCurrentValue.Text = baseValue.ToString();
            int value = baseValue + (int) numChange.Value;

            if (value > max)
            {
                value = max;
            } else if (value < 0)
            {
                value = 0;
            }

            lblTotalValue.Text = value.ToString();
        }

        private void btnApplyStun_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblTotalValue.Text, out int value))
            {
                if (rbStun.Checked)
                {
                    _character.StunHealth = value;
                }
                else
                {
                    _character.PhysicalHealth = value;
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Could not apply Damage.");
                DialogResult = DialogResult.TryAgain;
                this.Close();
            }
        }
    }
}

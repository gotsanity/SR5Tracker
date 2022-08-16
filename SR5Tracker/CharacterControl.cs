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
    public partial class CharacterControl : UserControl
    {
        private Character _character { get; set; }

        public event EventHandler<CharacterEventArgs> CharacterControlAddInit_Click;
        public event EventHandler<CharacterEventArgs> CharacterControlModifyInit_Click;
        public event EventHandler<CharacterEventArgs> CharacterControlRemoveCharacter_Click;

        public CharacterControl(Character character)
        {
            _character = character;
            InitializeComponent();
        }

        private void CharacterControl_Load(object sender, EventArgs e)
        {
            lblName.Text = _character.Name;
            lblStun.DataBindings.Add(new Binding("Text", _character, "StunHealth"));
            lblPhys.DataBindings.Add(new Binding("Text", _character, "PhysicalHealth"));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (CharacterControlRemoveCharacter_Click != null)
            {
                CharacterControlRemoveCharacter_Click(sender, new CharacterEventArgs() { Data = _character });
            }
            this.Hide();
            this.Dispose();
        }

        private void btnAddInit_Click(object sender, EventArgs e)
        {
            if (CharacterControlAddInit_Click != null)
            {
                CharacterControlAddInit_Click(sender, new CharacterEventArgs() { Data = _character });
            }
        }

        private void btnModifyHealth_Click(object sender, EventArgs e)
        {
            using (EditHealthForm frm = new EditHealthForm(_character))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _character.PhysicalHealth = frm._character.PhysicalHealth;
                    _character.StunHealth = frm._character.StunHealth;
                }
            }

            if (_character.PhysicalHealth <= 0)
            {
                MessageBox.Show(_character.Name + " has died.");
                btnRemove_Click(this, new EventArgs());
            }
        }

        private void btnEditInit_Click(object sender, EventArgs e)
        {
            if (CharacterControlModifyInit_Click != null)
            {
                CharacterControlModifyInit_Click(sender, new CharacterEventArgs() { Data = _character });
            }
        }
    }
}

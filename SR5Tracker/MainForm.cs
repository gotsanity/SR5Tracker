using System.Collections.Specialized;
using System.Linq;

namespace SR5Tracker
{
    public partial class MainForm : Form
    {

        private List<Character> _characters = new List<Character>();
        private List<Initiative> _CombatTurn = new List<Initiative>();
        private bool bIsCombatStarted = false;

        public MainForm()
        {
            StringCollection characters = Properties.Settings.Default.Characters;
            
            foreach (String item in characters)
            {
                _characters.Add(DeserializeCharacter(item.Split('\u002C')));
            }
            InitializeComponent();
            LoadCharacters();
        }

        private void LoadCharacters()
        {
            foreach (Character item in _characters)
            {
                CharacterControl character = new CharacterControl(item);
                character.CharacterControlAddInit_Click += new EventHandler<CharacterEventArgs>(AddInitiativeEvent);
                character.CharacterControlModifyInit_Click += new EventHandler<CharacterEventArgs>(AddInitiativeEvent);
                character.CharacterControlRemoveCharacter_Click += new EventHandler<CharacterEventArgs>(RemoveCharacterEvent);
                flowCharacters.Controls.Add(character);
            }
        }

        private Character DeserializeCharacter(String[] data)
        {
            Character character = new Character();



            character.Name = data[0];
            character.PhysicalHealth = Convert.ToInt32(data[1]);
            character.PhysicalHealthMax = Convert.ToInt32(data[2]);
            character.StunHealth = Convert.ToInt32(data[3]);
            character.StunHealthMax = Convert.ToInt32(data[4]);
            character.IsEnemy = Convert.ToBoolean(data[5]);

            return character;
        }

        private void AddInitiativeEvent(object sender, CharacterEventArgs e)
        {
            CaptureInitiativeForCharacter(e.Data);
        }

        private void CaptureInitiativeForCharacter(Character target)
        {
            using (var form = new InitiativeForm(target))
            {
                form.Character = target;

                Initiative existing = _CombatTurn.Find(i => i.Name == target.Name);

                if (existing != null)
                {
                    form.SetExisting(existing);
                }
                
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Initiative initiative = new Initiative() { Character = target, Name = target.Name, Type = form.InitiativeType, Value = form.InitiativeValue };

                    if (!_CombatTurn.Exists(c => c.Name == initiative.Name))
                    {
                        _CombatTurn.Add(initiative);
                        UpdateCombat();
                    }
                    else
                    {
                        int index = _CombatTurn.FindIndex(i => i.Name.Equals(initiative.Name, StringComparison.OrdinalIgnoreCase));
                        _CombatTurn[index].Type = form.InitiativeType;
                        _CombatTurn[index].Value = form.InitiativeValue;
                        UpdateCombat();
                    }
                }
            }
        }

        private void UpdateCombat()
        {
            if (_CombatTurn.Count < 1)
            {
                gridCombat.DataSource = null;
                if (bIsCombatStarted)
                {
                    bIsCombatStarted = false;
                    EndCombat();
                }
                return;
            }

            _CombatTurn = _CombatTurn.Where(i => i.Value > 0).ToList();
            _CombatTurn = _CombatTurn.OrderByDescending(c => c.Value).ToList();
            gridCombat.DataSource = _CombatTurn;
            if (gridCombat.Columns.Contains("Character"))
            {
                gridCombat.Columns.Remove("Character");
            }
        }

        
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Character newCharacter = new Character() { 
                Name = txtNewCharacter.Text, 
                PhysicalHealthMax = (int)numPhys.Value,
                PhysicalHealth = (int)numPhys.Value,
                StunHealthMax = (int)numStun.Value,
                StunHealth = (int)numStun.Value
            };
            CharacterControl character = new CharacterControl(newCharacter);
            character.CharacterControlAddInit_Click += new EventHandler<CharacterEventArgs>(AddInitiativeEvent);
            character.CharacterControlModifyInit_Click += new EventHandler<CharacterEventArgs>(AddInitiativeEvent);
            character.CharacterControlRemoveCharacter_Click += new EventHandler<CharacterEventArgs>(RemoveCharacterEvent);
            _characters.Add(newCharacter);
            flowCharacters.Controls.Add(character);

            

            txtNewCharacter.Text = "";
            numPhys.Value = 1;
            numStun.Value = 1;
            txtNewCharacter.Focus();
        }

        private void RemoveCharacterEvent(object sender, CharacterEventArgs e)
        {
            Initiative target = _CombatTurn.Find(c => c.Character.Name == e.Data.Name);
            _CombatTurn.Remove(target);
            Character character = _characters.Find(c => c.Name == e.Data.Name);
            _characters.Remove(character);
            UpdateCombat();
        }

        private void btnEndPass_Click(object sender, EventArgs e)
        {
            _CombatTurn.ForEach(i => i.Value -= 10);
            _CombatTurn = _CombatTurn.Where(i => i.Value > 0).ToList();

            if (_CombatTurn.Count < 1)
            {
                EndCombat();
            }

            UpdateCombat();
        }

        private void btnEndCombat_Click(object sender, EventArgs e)
        {
            if (!bIsCombatStarted)
            {
                StartCombat();
            }
            else
            {
                EndCombat();
            }
            

            UpdateCombat();
        }

        private void EndCombat()
        {
            _CombatTurn.Clear();

            if (_CombatTurn.Count < 1)
            {
                MessageBox.Show("Combat turn complete.");
                btnEndCombat.Text = "Start Combat";
                bIsCombatStarted = false;
            }
        }

        private void StartCombat()
        {
            foreach (Character character in _characters)
            {
                CaptureInitiativeForCharacter(character);
            }

            btnEndCombat.Text = "End Combat";
            bIsCombatStarted = true;
        }

        private void txtNewCharacter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAddNew_Click(sender, e);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR5Tracker
{
    public class Character : INotifyPropertyChanged
    {
        private int _physicalHealth;
        private int _stunHealth;

        public string Name { get; set; }
        public bool IsEnemy { get; set; }
        public int PhysicalHealth { 
            get { return _physicalHealth; }
            set {
                _physicalHealth = value;
                OnPropertyChanged("PhysicalHealth");
            }
        }
        public int PhysicalHealthMax { get; set; }
        public int StunHealth {
            get { return _stunHealth; }
            set
            {
                _stunHealth = value;
                OnPropertyChanged("StunHealth");
            }
        }
        public int StunHealthMax { get; set; }

        protected virtual void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}

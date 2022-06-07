using DataComparerMVVM.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataComparerMVVM.Core
{
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string MasterFolderPath
        {
            get { return ScdSetup.MasterFolderPath; }
            set
            {
                if (ScdSetup.MasterFolderPath != value)
                {
                    ScdSetup.MasterFolderPath = value;
                    OnPropertyChanged("MasterFolderPath");
                }
            }
        }
        public string TestFolderPath
        {
            get { return ScdSetup.TestFolderPath; }
            set
            {
                if (ScdSetup.TestFolderPath != value)
                {
                    ScdSetup.TestFolderPath = value;
                    OnPropertyChanged("TestFolderPath");
                }
            }
        }
    }
}
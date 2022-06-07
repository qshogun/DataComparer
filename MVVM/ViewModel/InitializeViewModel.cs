using DataComparerMVVM.Commands;
using DataComparerMVVM.Core;
using DataComparerMVVM.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DataComparerMVVM.MVVM.ViewModel
{
    sealed class InitializeViewModel : ObservableObject
    {
        private RelayCommand _selectMasterFolder;
        private RelayCommand _selectTestFolder;

        public ICommand SelectMasterFolder => _selectMasterFolder ??= new RelayCommand(PerformSelectMasterFolder);
        public ICommand SelectTestFolder => _selectTestFolder ??= new RelayCommand(PerformSelectTestFolder);

        private void PerformSelectMasterFolder(object commandParameter)
        {
            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select folder...";
            folderDialog.UseDescriptionForTitle = true;
            folderDialog.InitialDirectory = "C:\\";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                MasterFolderPath = folderDialog.SelectedPath;
            }
        }

        private void PerformSelectTestFolder(object commandParameter)
        {
            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select folder...";
            folderDialog.UseDescriptionForTitle = true;
            folderDialog.InitialDirectory = "C:\\";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                TestFolderPath = folderDialog.SelectedPath;
            }
        }

        public InitializeViewModel()
        {
            MasterFolderPath = "Choose bin folder path for SCD Master";
            TestFolderPath = "Choose bin folder path for SCD Test";
        }
    }
}
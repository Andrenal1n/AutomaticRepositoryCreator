using AutomaticRepositoryCreator.Core;
using AutomaticRepositoryCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticRepositoryCreator.MVVM.ViewModel
{
    internal class NewRepoViewModel : ObservableObject
    {
        private string _selectedFolderPath;
        public string SelectedFolderPath
        {
            get { return _selectedFolderPath; }
            set
            {
                _selectedFolderPath = value;
                OnPropertyChanged();
            }
        }

        private string _projectName;
        public string ProjectName
        {
            get { return _projectName; }
            set
            {
                _projectName = value;
                OnPropertyChanged();
            }
        }

        private string _projectDescription;
        public string ProjectDescription
        {
            get { return _projectDescription; }
            set
            {
                _projectDescription = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand OpenFolderCommand { get; set; }
        public RelayCommand CreateProjectFolderCommand { get; set; }
        public NewRepoViewModel() 
        {
            OpenFolderCommand = new RelayCommand(ExecuteOpenFolderCommand);
            CreateProjectFolderCommand = new RelayCommand(ExecuteCreateProjectFolderCommand);
        }
        private void ExecuteOpenFolderCommand(object parameter)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SelectedFolderPath = dialog.SelectedPath;
            }
        }

        private void ExecuteCreateProjectFolderCommand(object parameter)
        {
            NewRepoModel model = new NewRepoModel();
            _ = model.CreateProjectFolder(ProjectName, SelectedFolderPath);
            _ = model.CreateReadmeFile(ProjectDescription, SelectedFolderPath, ProjectName);
            _ = model.InitializeGit(SelectedFolderPath, ProjectName);
        }
    }
}

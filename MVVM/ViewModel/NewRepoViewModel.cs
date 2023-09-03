using AutomaticRepositoryCreator.Core;
using AutomaticRepositoryCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Wpf;

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
        public RelayCommand CreateRepoCommand { get; set; }
        public NewRepoViewModel() 
        {
            OpenFolderCommand = new RelayCommand(ExecuteOpenFolderCommand);
            CreateRepoCommand = new RelayCommand(ExecuteCreateRepoCommand);
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

        private void OpenGitHubLogin()
        {
            // Erstelle ein neues Popup-Fenster
            var popupWindow = new Window
            {
                Title = "GitHub Login",
                Width = 800,
                Height = 600
            };

            // Erstelle ein WebView2-Steuerelement im Popup-Fenster
            var webView = new WebView2();
            webView.Source = new Uri("https://github.com/login");

            // Füge das WebView2-Steuerelement zum Popup-Fenster hinzu
            popupWindow.Content = webView;

            // Zeige das Popup-Fenster an
            popupWindow.ShowDialog();
        }


        private void ExecuteCreateRepoCommand(object parameter)
        {
            NewRepoModel model = new NewRepoModel();
            _ = model.CreateProjectFolder(ProjectName, SelectedFolderPath);
            _ = model.CreateReadmeFile(ProjectDescription, SelectedFolderPath, ProjectName);
            _ = model.InitializeGit(SelectedFolderPath, ProjectName);
            OpenGitHubLogin();
        }
    }
}

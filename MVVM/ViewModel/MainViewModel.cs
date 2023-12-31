﻿using AutomaticRepositoryCreator.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutomaticRepositoryCreator.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand NewRepoCommand { get; set; }
        public RelayCommand ChangePathCommand { get; set; }
        public RelayCommand HelpCommand { get; set; }
        public RelayCommand MinimizeCommand { get; set; }
        public RelayCommand CloseCommand { get; set; }
        public RelayCommand GithubLinkCommand { get; set; }
        public RelayCommand DiscordLinkCommand { get; set; }
        public NewRepoViewModel NewRepoVM { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public ChangePathViewModel ChangePathVM { get; set; }
        public HelpViewModel HelpVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }

            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel() 
        {
            MinimizeCommand = new RelayCommand(Minimize);
            CloseCommand = new RelayCommand(Close);
            GithubLinkCommand = new RelayCommand(GithubLink);
            DiscordLinkCommand = new RelayCommand(DiscordLink);

            HomeVM = new HomeViewModel();
            NewRepoVM = new NewRepoViewModel();
            ChangePathVM = new ChangePathViewModel();
            HelpVM = new HelpViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            NewRepoCommand = new RelayCommand(o =>
            {
                CurrentView = NewRepoVM;
            });

            ChangePathCommand = new RelayCommand(o =>
            {
                CurrentView = ChangePathVM;
            });

            HelpCommand = new RelayCommand(o =>
            {
                CurrentView = HelpVM;
            });
        }
        private void Minimize(object parameter)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Close(object parameter)
        {
            Application.Current.Shutdown();
        }

        private void GithubLink(object parameter)
        {
            string githubLink = "https://github.com/Andrenal1n/";

            Process.Start(new ProcessStartInfo
            {
                FileName = githubLink,
                UseShellExecute = true
            });
        }
        private void DiscordLink(object parameter)
        {
            string discordLink = "https://discord.com/channels/1049617057286721546/1049617057286721549";

            Process.Start(new ProcessStartInfo
            {
                FileName = discordLink,
                UseShellExecute = true
            });
        }

    }
}

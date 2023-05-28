using Avalonia.Interactivity;
using ReactiveUI;
using RGR.Models;
using RGR.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace RGR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string path;
        public MainWindow mainWindow;
        private ObservableCollection<Class_Project> projectsToHistory;

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref path, value);
            }
        }

        public MainWindowViewModel(MainWindow mainWindow1)
        {
            mainWindow = mainWindow1;
            projectsToHistory = new ObservableCollection<Class_Project>();
            //var colectionLoad = new LoaderXML();
            //ProjectsToHistory = new ObservableCollection<Class_Project>(colectionLoad.XML_Load());
        }

        public void Check_button(string name)
        {
            if (name == "New_prog")
            {
                mainWindow.Create_Programm(null, null);
            }
            else if (name == "Create_prog")
            {
                mainWindow.OpenSecondWindow(null, null);
            }
        }

        public ObservableCollection<Class_Project> ProjectsToHistory
        {
            get => projectsToHistory;
            set => this.RaiseAndSetIfChanged(ref projectsToHistory, value);
        }

        public void DoubleTap()
        {
            Debug.WriteLine(ProjectsToHistory[currentIndex].Path);
            ProgrammViewModel dt = new ProgrammViewModel();
            dt.LoadCollection(ProjectsToHistory[currentIndex].Path);
            Debug.WriteLine(ProjectsToHistory[currentIndex].Path);

        }

        private int currentIndex;
        public int currentIndexProperties
        {
            get => currentIndex; set
            {
                this.RaiseAndSetIfChanged(ref currentIndex, value);
            }
        }
    }
}

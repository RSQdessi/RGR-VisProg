using DynamicData.Binding;
using System.Collections.ObjectModel;

namespace RGR.Models
{
    public class Class_Project : AbstractNotifyPropertyChanged
    {
    	private string nameProject;
        private string path;
        private ObservableCollection<Class_Circuit> circuits;

        public Class_Project()
        {
        	NameProject = "Untitled";
            Path = "Untitled";


            Circuits = new ObservableCollection<Class_Circuit>();
        }
        public string Path
        {
            get => path;
            set => SetAndRaise(ref path, value);
        }
        public string NameProject
        {
            get => nameProject;
            set=> SetAndRaise(ref nameProject, value);
        }

        public ObservableCollection<Class_Circuit> Circuits
        {
            get => circuits;
            set => SetAndRaise(ref circuits, value);
        }
    }
}

using Avalonia;
using Avalonia.Controls.Primitives;
using RGR.Models;
using System.Collections.ObjectModel;

namespace RGR.Views.Elements
{
    public class Element_Out : TemplatedControl
    {
        public static readonly StyledProperty<string> PowerProperty = AvaloniaProperty.Register<Element_Out, string>("Power");

        public string Power 
        { 
            get => GetValue(PowerProperty); 
            set => SetValue(PowerProperty, value); 
        }
    }
}

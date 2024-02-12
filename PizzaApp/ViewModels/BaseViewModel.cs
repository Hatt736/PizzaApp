using System.ComponentModel;
using System.Runtime.CompilerServices;

using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaApp.ViewModels
{
    public class BaseViewModel :ObservableObject// : INotifyPropertyChanged 
    {
        public INavigation Navigation { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    var changed = PropertyChanged;
        //    if (changed == null)
        //        return;

        //    changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}

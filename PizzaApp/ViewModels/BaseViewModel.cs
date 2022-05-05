using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PizzaApp.ViewModels
{
    public class BaseViewModel  : INotifyPropertyChanged 
    {
        public BaseViewModel()
        {
            CartItemsQuanity = "99";
        }
        public INavigation Navigation { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private string cartItemsQuanity;
        public string CartItemsQuanity
        {
            get { return cartItemsQuanity; }
            set
            {
                cartItemsQuanity = value;
                OnPropertyChanged();
            }
        }


    }
}

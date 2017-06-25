using Prism.Commands;
using Prism.Navigation;
using System.ComponentModel;

namespace PrismUnityApp1.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string MyEntry { get; set; }

        public string MyLabel { get; set; }

        public DelegateCommand HelloCommand { get; set; }

        public MainPageViewModel()
        {
            HelloCommand = new DelegateCommand(() =>
            {
                MyLabel = MyEntry;
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
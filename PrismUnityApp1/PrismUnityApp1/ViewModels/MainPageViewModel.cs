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

        private readonly INavigationService navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            HelloCommand = new DelegateCommand(() =>
            {
                MyLabel = MyEntry;
                this.navigationService.NavigateAsync("NewPage");
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
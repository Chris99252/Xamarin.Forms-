using Prism.Commands;
using Prism.Navigation;
using System.ComponentModel;

namespace PrismUnityApp1.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _MyEntry;
        private string _MyLabel;
        public DelegateCommand HelloCommand { get; set; }

        public string MyEntry
        {
            get { return _MyEntry; }
            set
            {
                if (_MyEntry != value)
                {
                    _MyEntry = value;
                    OnPropertyChanged("MyEntry");
                }
            }
        }

        public string MyLabel
        {
            get { return _MyLabel; }
            set
            {
                if (_MyLabel != value)
                {
                    _MyLabel = value;
                    OnPropertyChanged("MyLabel");
                }
            }
        }

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

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                // 若  PropertyChanged 有被綁定，則將會執行這個事件，
                // 以進行頁面控制項的內容更新
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
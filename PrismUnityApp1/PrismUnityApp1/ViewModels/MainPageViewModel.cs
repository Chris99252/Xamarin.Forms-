using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.ComponentModel;

namespace PrismUnityApp1.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand HelloCommand { get; set; }

        #region MyEntry

        private string _MyEntry;

        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string MyEntry
        {
            get { return this._MyEntry; }
            set { this.SetProperty(ref this._MyEntry, value); }
        }

        #endregion MyEntry

        #region MyLabel

        private string _MyLabel;

        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string MyLabel
        {
            get { return this._MyLabel; }
            set { this.SetProperty(ref this._MyLabel, value); }
        }

        #endregion MyLabel

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
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    class HomeViewModel
    {
        private readonly INavigation _navigation;

        public HomeViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        private ICommand _goToDetailsCommans;
        public ICommand GoToDetailsCommand => _goToDetailsCommans ?? (_goToDetailsCommans = new Command(OnGoToDetails));

        private void OnGoToDetails()
        {
            _navigation.PushAsync(new DetailsPage());
        }
    }
}

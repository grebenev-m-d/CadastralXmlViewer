using CadastralXmlViewer.Core;
using CadastralXmlViewer.NavigationService;

namespace CadastralXmlViewer.MVVM.ViewModel
{
    public class MainViewModel : Core.ViewModel
    {
        private INavigationService _navigation;

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand NavigateToHelpCommand { get; set; }
        public RelayCommand NavigateToXmlViewerCommand { get; set; }
        public MainViewModel(INavigationService navService)
        {
            Navigation = navService;

            NavigateToHelpCommand = new RelayCommand(obj =>
            { Navigation.NavigateTo<HelpViewModel>(); }, obj => true);
            NavigateToXmlViewerCommand = new RelayCommand(obj =>
            { Navigation.NavigateTo<CadastralXmlViewerViewModel>(); }, obj => true);
        }

    }
}

using CadastralXmlViewer.Core;

namespace CadastralXmlViewer.NavigationService
{
    public class NavigationService : ObservableObject, INavigationService
    {
        private readonly Func<Type, ViewModel> _viewModelFactory;
        private ViewModel _currentView;

        /// <summary>
        /// Текущее представление.
        /// </summary>
        public ViewModel CurrentView
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public NavigationService(Func<Type, ViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        /// <summary>
        /// Переход к указанной модели представления.
        /// </summary>
        /// <typeparam name="TViewModel"> Тип модели представления, к которой нужно перейти. </typeparam>
        public void NavigateTo<TViewModel>() where TViewModel : ViewModel
        {
            // Создание экземпляра указанной модели представления с использованием фабрики моделей представлений
            ViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewModel));

            // Установка текущего представления основного содержимого в созданную модель представления
            CurrentView = viewModel;
        }
    }
}

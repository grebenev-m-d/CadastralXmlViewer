using CadastralXmlViewer.Core;

namespace CadastralXmlViewer.NavigationService
{
    /// <summary>
    /// Сервис навигации между ViewModel.
    /// </summary>
    public interface INavigationService
    {
        ViewModel CurrentView { get; }
        void NavigateTo<T>() where T : ViewModel;
    }
}

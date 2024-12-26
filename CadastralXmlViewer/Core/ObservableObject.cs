using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CadastralXmlViewer.Core
{
    /// <summary>
    /// Базовый класс для объектов, которые должны уведомлять клиентов об изменении значения свойства.
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие, которое происходит при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызывает событие PropertyChanged для уведомления клиентов об изменении значения свойства.
        /// </summary>
        /// <param name="propertyName"> Имя изменившегося свойства. </param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? proprtyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proprtyName));
        }
    }
}

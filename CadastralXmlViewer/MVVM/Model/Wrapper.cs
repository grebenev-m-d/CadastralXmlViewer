namespace CadastralXmlViewer.MVVM.Model
{
    public class Wrapper<T>
    {
        public T Value { get; set; }
        public bool IsSelected { get; set; }
        public RecordType RecordType { get; set; }
    }
}

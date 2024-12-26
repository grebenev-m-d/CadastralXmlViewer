using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using CadastralXmlViewer.Core;
using CadastralXmlViewer.Data.XmlModels;
using CadastralXmlViewer.Helper;
using CadastralXmlViewer.MVVM.Model;
using Microsoft.Win32;
namespace CadastralXmlViewer.MVVM.ViewModel
{
    public class CadastralXmlViewerViewModel : Core.ViewModel
    {
        private CadastralPlan _cadastralPlan;
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand OpenCommand { get; set; }

        public CadastralXmlViewerViewModel()
        {
            SaveCommand = new RelayCommand(ExecuteSaveCommand, CanExecuteSaveCommand);
            OpenCommand = new RelayCommand(ExecuteOpenCommand, CanExecuteOpenCommand);
        }

        private ObservableCollection<Wrapper<LandRecord>> _parcels;
        public ObservableCollection<Wrapper<LandRecord>> SelectedParcels
        {
            get => _parcels;
            set
            {
                _parcels = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Wrapper<object>> _objectRealty;
        public ObservableCollection<Wrapper<object>> SelectedObjectRealty
        {
            get => _objectRealty;
            set
            {
                _objectRealty = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Wrapper<EntitySpatial>> _spatialData;
        public ObservableCollection<Wrapper<EntitySpatial>> SelectedSpatialData
        {
            get => _spatialData;
            set
            {
                _spatialData = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Wrapper<MunicipalBoundaryRecord>> _bounds;
        public ObservableCollection<Wrapper<MunicipalBoundaryRecord>> SelectedBounds
        {
            get => _bounds;
            set
            {
                _bounds = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Wrapper<ZoneAndTerritoryRecord>> _zones;
        public ObservableCollection<Wrapper<ZoneAndTerritoryRecord>> SelectedZones
        {
            get => _zones;
            set
            {
                _zones = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Создание кадастрового плана из выбранных узлов.
        /// </summary>
        /// <returns> Возвращает новый экземпляр CadastralPlan, содержащий только выбранные узлы. </returns>
        public CadastralPlan CreateSelectedCadastralPlan()
        {
            var selectedCadastralPlan = new CadastralPlan
            {
                DetailsStatement = _cadastralPlan.DetailsStatement,
                DetailsRequest = _cadastralPlan.DetailsRequest,
                CadastralBlocks = new List<CadastralBlock>
            {
                new CadastralBlock
                {
                    RecordData = new RecordData
                    {
                        BaseData = new BaseData
                            {
                                LandRecords = SelectedParcels
                                .Where(wrapper => wrapper.IsSelected)
                                .Select(wrapper => wrapper.Value)
                                .ToList(),

                                BuildRecords = SelectedObjectRealty
                                .Where(wrapper => wrapper.IsSelected && wrapper.Value is BuildRecord)
                                .Select(wrapper => (BuildRecord)wrapper.Value)
                                .ToList(),

                                ConstructionRecords = SelectedObjectRealty
                                .Where(wrapper => wrapper.IsSelected && wrapper.Value is ConstructionRecord)
                                .Select(wrapper => (ConstructionRecord)wrapper.Value)
                                .ToList()
                            }
                    },
                    SpatialData = new SpatialData
                    {
                        EntitySpatials = SelectedSpatialData
                        .Where(wrapper => wrapper.IsSelected)
                        .Select(wrapper => wrapper.Value)
                        .ToList()
                    },
                    MunicipalBoundaryRecords = SelectedBounds
                    .Where(wrapper => wrapper.IsSelected)
                    .Select(wrapper => wrapper.Value)
                    .ToList(),

                    ZonesAndTerritoriesRecords = SelectedZones
                    .Where(wrapper => wrapper.IsSelected)
                    .Select(wrapper => wrapper.Value)
                    .ToList()
                }
            }
            };

            return selectedCadastralPlan;
        }

        /// <summary>
        /// Инициализация свойств кадастрового плана.
        /// </summary>
        /// <param name="cadastralPlan"> Экземпляр CadastralPlan, используемый для инициализации свойств. </param>
        public void InitializePropertiesCadastralPlan(CadastralPlan cadastralPlan)
        {
            if (cadastralPlan == null || cadastralPlan.CadastralBlocks == null || cadastralPlan.CadastralBlocks.Count == 0)
                return;

            var cadastralBlock = cadastralPlan.CadastralBlocks[0];

            SelectedParcels = new ObservableCollection<Wrapper<LandRecord>>(
                cadastralBlock.RecordData.BaseData.LandRecords
                .Select(record => new Wrapper<LandRecord>
                {
                    Value = record,
                    IsSelected = false,
                    RecordType = RecordType.LandRecords
                })
            );

            SelectedObjectRealty = new ObservableCollection<Wrapper<object>>(
                cadastralBlock.RecordData.BaseData.BuildRecords
                .Select(record => new Wrapper<object> 
                { 
                    Value = record, 
                    IsSelected = false, 
                    RecordType = RecordType.BuildRecords 
                })
                .Concat(cadastralBlock.RecordData.BaseData.ConstructionRecords
                .Select(record => new Wrapper<object> 
                { 
                    Value = record, 
                    IsSelected = false, 
                    RecordType = RecordType.ConstructionRecords 
                }))
            );

            SelectedSpatialData = new ObservableCollection<Wrapper<EntitySpatial>>(
                cadastralBlock.SpatialData.EntitySpatials
                .Select(record => new Wrapper<EntitySpatial>
                {
                    Value = record,
                    IsSelected = false,
                    RecordType = RecordType.SpatialData
                })
            );

            SelectedBounds = new ObservableCollection<Wrapper<MunicipalBoundaryRecord>>(
                cadastralBlock.MunicipalBoundaryRecords
                .Select(record => new Wrapper<MunicipalBoundaryRecord>
                {
                    Value = record,
                    IsSelected = false,
                    RecordType = RecordType.MunicipalBoundaries
                })
            );

            SelectedZones = new ObservableCollection<Wrapper<ZoneAndTerritoryRecord>>(
                cadastralBlock.ZonesAndTerritoriesRecords
                .Select(record => new Wrapper<ZoneAndTerritoryRecord>
                {
                    Value = record,
                    IsSelected = false,
                    RecordType = RecordType.ZonesAndTerritoriesRecords
                })
            );
        }

        private void ExecuteSaveCommand(object parameter)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Title = "Сохранить XML файл"
            };

            if (saveFileDialog.ShowDialog() != true) 
                return; // Если путь не был выбран, выходим из метода

            var filePath = saveFileDialog.FileName;

            try
            {
                var selectedCadastralPlan = XmlHelper.Serialize(CreateSelectedCadastralPlan());
                File.WriteAllText(filePath, selectedCadastralPlan);
                MessageBox.Show("Файл успешно сохранен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CanExecuteSaveCommand(object parameter) => true;

        private void ExecuteOpenCommand(object parameter)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Title = "Выберите XML файл"
            };

            if (openFileDialog.ShowDialog() != true) 
                return; // Если файл не был выбран, выходим из метода

            var filePath = openFileDialog.FileName;

            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Укажите путь для чтения файла.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                
                return;
            }

            try
            {
                var xmlContent = File.ReadAllText(filePath);
                _cadastralPlan = XmlHelper.Deserialize<CadastralPlan>(xmlContent);
                InitializePropertiesCadastralPlan(_cadastralPlan);
                MessageBox.Show("Файл успешно открыт!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CanExecuteOpenCommand(object parameter) => true;
    }
}

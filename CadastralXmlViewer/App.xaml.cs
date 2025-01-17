﻿using System.Windows;
using CadastralXmlViewer.Core;
using CadastralXmlViewer.MVVM.ViewModel;
using CadastralXmlViewer.NavigationService;
using Microsoft.Extensions.DependencyInjection;

namespace CadastralXmlViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<HelpViewModel>();
            services.AddSingleton<CadastralXmlViewerViewModel>();

            services.AddSingleton<INavigationService, NavigationService.NavigationService>();

            services.AddSingleton<Func<Type, ViewModel>>(
                serviceProvider =>
                viewModelType => (ViewModel)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }

}

using System;
using Microsoft.Extensions.DependencyInjection;
using SQLiteMVVMApp;
using SQLiteMVVMApp.Database;
using SQLiteMVVMApp.Services;
using SQLiteMVVMApp.ViewModels;

namespace SQLiteMVVMApp
{
    public class Dependencies
    {
        private IServiceCollection services = new ServiceCollection();

        public Dependencies Load()
        {
            services.AddTransient<INotificationsService, NotificationsService>();
            services.AddTransient<MainPageViewModel>();
            services.AddTransient<MainPage>();
            services.AddTransient<PeopleDb>((p) => new PeopleDb(Constants.DatabasePath));
            return this;
        }
        
        public IServiceProvider GetServiceProvider()
            => services.BuildServiceProvider();
    }
}
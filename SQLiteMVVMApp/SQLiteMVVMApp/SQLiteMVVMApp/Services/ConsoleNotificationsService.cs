using System;
using System.Threading.Tasks;

namespace SQLiteMVVMApp.Services
{
    public class ConsoleNotificationsService :INotificationsService
    {
        public Task ShowSuccessMessageAsync(string message)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"SUCCESS: {message}");
            });
        }

        public Task ShowErrorMessageAsync(string message)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"ERROR: {message}");
            });
        }
    }
}
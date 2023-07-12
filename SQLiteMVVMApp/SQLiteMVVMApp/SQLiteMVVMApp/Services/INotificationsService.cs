using System.Threading.Tasks;

namespace SQLiteMVVMApp.Services
{
    public interface INotificationsService
    {
        Task ShowSuccessMessageAsync(string message);
        Task ShowErrorMessageAsync(string message);
    }
}
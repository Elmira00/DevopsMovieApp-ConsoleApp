namespace DevopsMovieApp_ConsoleApp.Services
{
    internal interface IQueueService
    {
        Task SendMessageAsync(string message);
        Task<string> ReceiveMessageAsync();
    }
}

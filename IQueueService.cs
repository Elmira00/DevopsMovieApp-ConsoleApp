namespace DevopsMovieApp_CosoleApp.Services
{
    internal interface IQueueService
    {
        Task SendMessageAsync(string message);
        Task<string> ReceiveMessageAsync();
    }
}

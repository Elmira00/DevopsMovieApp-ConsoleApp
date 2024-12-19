using DevopsMovieApp_ConsoleApp.Services;
using Microsoft.Extensions.Configuration;

namespace DevopsMovieApp_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("app.json", optional: false, reloadOnChange: true).Build();


            string connectionString = configuration.GetSection("AzureStorage:ConnectionString").Value;
            //  Console.WriteLine($"Connection string: {connectionString}");


            QueueService _queueService = new QueueService(connectionString, "moviequeue");

            Console.Write("Enter Movie name :  ");
            string movie = Console.ReadLine();
            _queueService.SendMessageAsync(movie);
        }
    }
}

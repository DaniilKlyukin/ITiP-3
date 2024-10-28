using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startup = new Startup();
            
            var services = new ServiceCollection();

            startup.ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetRequiredService<Logger>();

            logger.Log("Запуск программы");
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Единая точка входа для конфигурации сервисов
            // Если нам нужно поменять сервис во всей программе, то мы можем поменять его в данном методе
            services.AddTransient<ILoggerService, ConsoleLoggerService>()
                .AddTransient<Logger>();
        }
    }

    public interface ILoggerService
    {
        public void Write(string message);
    }

    public class ConsoleLoggerService : ILoggerService
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FileLoggerService : ILoggerService
    {
        public string path;

        public FileLoggerService(string path)
        {
            this.path = path;
        }

        public void Write(string message)
        {
            File.WriteAllText(path, message);
        }
    }

    public class Logger
    {
        private ILoggerService service;

        public Logger(ILoggerService service) => this.service = service;

        public void Log(string message)
        {
            service.Write($"{DateTime.Now} {message}");
        }
    }
}

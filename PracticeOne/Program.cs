using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracticeOne.Fifth;
using Serilog;
using System;

namespace PracticeOne
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            /*ApplicationConfiguration.Initialize();
            Application.Run(new Form4());*/
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new();
            ConfigureServices(services);
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<Form5>());
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Settings.json")
                .Build();
            services.AddSingleton<Form5>()
                    .AddLogging(builder =>
                    {
                        builder.AddSerilog(new LoggerConfiguration()
                            .ReadFrom.Configuration(configuration)
                            .CreateLogger());
                    });
        }
    }
}
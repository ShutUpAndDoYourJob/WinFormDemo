using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using WinFormDemo.Services;

namespace WinFormDemo
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                ConfigureLogging();
                ConfigureServices();

                Log.Debug("IsEnabledByUser: {IsEnabledByUser}", System.Windows.Forms.VisualStyles.VisualStyleInformation.IsEnabledByUser);
                Log.Debug("IsSupportedByOS: {IsSupportedByOS}", System.Windows.Forms.VisualStyles.VisualStyleInformation.IsSupportedByOS);

                Application.SetHighDpiMode(HighDpiMode.SystemAware);

                LogVisualStyleInformation();
                Application.EnableVisualStyles();

                Log.Debug("After EnableVisualStyles()");
                LogVisualStyleInformation();

                Application.SetCompatibleTextRenderingDefault(true);
                Application.Run(new Form1(ServiceProvider, ServiceProvider.GetService<ILogger<Form1>>()));

                //Application.Run(ServiceProvider.GetService<Form1>());
                Log.Information("Application closed");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Fatal error occured and application is forced to close");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        internal static IConfiguration Configuration;
        internal static IServiceProvider ServiceProvider;
        internal static IBindingListSink BindingListSink;

        private static void ConfigureLogging()
        {
            BindingListSink = new BindingListSink();

            var logFilePath = System.IO.Path.Combine(AppContext.BaseDirectory, "WinFormDemo.log");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(logFilePath, fileSizeLimitBytes: 128 * 1024)
                .WriteTo.Sink(BindingListSink)
                .CreateLogger();

            Log.Logger.Information("Logs are saved to: {Path}", logFilePath);
        }

        private static void ConfigureServices()
        {
            Log.Logger.Debug("Build configurations");

            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false, reloadOnChange: true);

            Configuration = configurationBuilder.Build();

            Log.Logger.Debug("Build services");

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(Log.Logger));
            serviceCollection.AddOptions();

            serviceCollection.AddSingleton(Configuration);
            serviceCollection.AddSingleton<IBindingListSink>(BindingListSink);

            serviceCollection.AddTransient<Form1>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void LogVisualStyleInformation()
        {
            Log.Debug("RenderWithVisualStyles: {RenderWithVisualStyles}", Application.RenderWithVisualStyles);
            Log.Debug("UseVisualStyles: {UseVisualStyles}", Application.UseVisualStyles);
            Log.Debug("VisualStyleState: {VisualStyleState}", Application.VisualStyleState);
        }
    }
}

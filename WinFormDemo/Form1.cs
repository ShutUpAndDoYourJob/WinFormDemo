using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using WinFormDemo.Services;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1(IServiceProvider service, ILogger<Form1> logger)
        {
            InitializeComponent();

            _configuration = service.GetService<IConfiguration>();
            _service = service;
            _logger = logger;

            listBoxLogs.DataSource = _service.GetService<IBindingListSink>().BindingList;
            listBoxLogs.Refresh();

            toolStripStatusLabel.Text = _configuration.GetValue<string>("Environment");

            _logger.LogInformation("Application started");
        }

        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _service;
        private readonly ILogger _logger;

        private async void buttonDatabaseTime_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Dispaly current database time");

                StartProgressBar(buttonTaskDelay, buttonDatabaseTime);

                _logger.LogDebug("Simulate some network delays");
                await Task.Delay(new TimeSpan(0, 0, 2));

                var password = new SecureString();
                foreach (var chr in textBoxPassword.Text)
                {
                    password.AppendChar(chr);
                }
                password.MakeReadOnly();

                var credential = new OracleCredential(textBoxUser.Text.Trim(), password);
                using (var connection = new OracleConnection($"DATA SOURCE={textBoxDataSource.Text};", credential))
                {
                    await connection.OpenAsync();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT SYSTIMESTAMP FROM DUAL";
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                textBoxOutput.Text += "Current database time is: " + reader.GetDateTime(0) + Environment.NewLine;
                            }
                            else
                            {
                                textBoxOutput.Text += "No result returned" + Environment.NewLine;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            finally
            {
                StopProgressBar(buttonTaskDelay, buttonDatabaseTime);
            }
        }

        private async void buttonTaskDelay_Click(object sender, EventArgs e)
        {
            _logger.LogInformation("Run async task for 10 sec");

            StartProgressBar(buttonTaskDelay, buttonDatabaseTime);

            textBoxOutput.Text += "Start task with 10 sec duration" + Environment.NewLine;

            await Task.Delay(new TimeSpan(0, 0, 10));

            textBoxOutput.Text += "Task finished" + Environment.NewLine;

            StopProgressBar(buttonTaskDelay, buttonDatabaseTime);

            _logger.LogInformation("Async task completed");
        }

        private void StartProgressBar(params Control[] controls)
        {
            foreach(var control in controls)
            {
                control.Enabled = false;
            }

            toolStripProgressBar.Enabled = true;
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.MarqueeAnimationSpeed = 100;
            toolStripProgressBar.Visible = true;
        }

        private void StopProgressBar(params Control[] controls)
        {
            toolStripProgressBar.Visible = false;
            toolStripProgressBar.MarqueeAnimationSpeed = 0;
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Enabled = false;

            foreach (var control in controls)
            {
                control.Enabled = true;
            }
        }

        private void textBoxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}

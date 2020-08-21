using System;
using System.ComponentModel;
using Serilog.Events;

namespace WinFormDemo.Services
{
    public class BindingListSink : IBindingListSink
    {
        public BindingListSink()
        {
            BindingList = new BindingList<string>();
        }

        public BindingList<string> BindingList { get; }

        private int _maxLength = 1000;
        public int MaxLength
        {
            get { return _maxLength; }
            set
            {
                _maxLength = value >= 100 && value <= 1000000
                    ? value
                    : throw new ArgumentOutOfRangeException(
                    "Max log entry has to be greater or equal to 100 and less or equal to 1,000,000");
            }
        }

        public void Emit(LogEvent logEvent)
        {
            while (BindingList.Count > (MaxLength - 1))
            {
                BindingList.RemoveAt(0);
            }

            var timestamp = logEvent.Timestamp.LocalDateTime;

            var logLevel = logEvent.Level switch
            {
                LogEventLevel.Information   => "Info",
                _                           => logEvent.Level.ToString(),
            };

            BindingList.Add($"[{timestamp:HH:mm:ss} {logLevel}]: {logEvent.RenderMessage()}");
        }
    }
}

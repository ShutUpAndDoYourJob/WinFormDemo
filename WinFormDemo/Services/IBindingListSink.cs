using System.ComponentModel;
using Serilog.Core;

namespace WinFormDemo.Services
{
    public interface IBindingListSink : ILogEventSink
    {
        BindingList<string> BindingList { get; }
        int MaxLength { get; set; }
    }
}
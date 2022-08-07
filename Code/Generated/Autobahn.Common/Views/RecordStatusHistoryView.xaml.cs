//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RecordStatusHistoryView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RecordStatusHistoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordStatusHistoryView : ContentPage
    {
        /// <summary>
        /// Inject the IRecordStatusHistoryViewModel as the data context for the view
        /// </summary>
        public RecordStatusHistoryView(IRecordStatusHistoryViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

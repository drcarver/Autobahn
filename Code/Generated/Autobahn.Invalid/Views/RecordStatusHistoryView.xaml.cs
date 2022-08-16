//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RecordStatusHistoryView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The RecordStatusHistoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordStatusHistoryView : ContentPage
    {
        /// <summary>
        /// Inject the IRecordStatusHistory View Model as the data context for the view
        /// </summary>
        public RecordStatusHistoryView(Interfaces.IRecordStatusHistory vm)
        {
            BindingContext  = vm;
        }
    }
}
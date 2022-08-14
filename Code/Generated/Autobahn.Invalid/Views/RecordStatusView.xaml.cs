//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RecordStatusView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The RecordStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IRecordStatus View Model as the data context for the view
        /// </summary>
        public RecordStatusView(Interfaces.IRecordStatus vm)
        {
            BindingContext  = vm;
        }
    }
}

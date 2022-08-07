//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RecordStatusView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RecordStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IRecordStatusViewModel as the data context for the view
        /// </summary>
        public RecordStatusView(IRecordStatusViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Common Models
//* FileName:   RecordView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordView : ContentPage
    {
        /// <summary>
        /// Inject the IRecord View Model as the data context for the view
        /// </summary>
        public RecordView(Interfaces.IRecord vm)
        {
            BindingContext  = vm;
        }
    }
}

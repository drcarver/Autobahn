//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   QuarterlyEmploymentRecordView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The QuarterlyEmploymentRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuarterlyEmploymentRecordView : ContentPage
    {
        /// <summary>
        /// Inject the QuarterlyEmploymentRecordViewModel as the data context for the view
        /// </summary>
        public QuarterlyEmploymentRecordView(QuarterlyEmploymentRecordViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

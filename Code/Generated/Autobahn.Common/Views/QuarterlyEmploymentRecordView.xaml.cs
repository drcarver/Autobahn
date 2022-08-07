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
        /// Inject the IQuarterlyEmploymentRecordViewModel as the data context for the view
        /// </summary>
        public QuarterlyEmploymentRecordView(IQuarterlyEmploymentRecordViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

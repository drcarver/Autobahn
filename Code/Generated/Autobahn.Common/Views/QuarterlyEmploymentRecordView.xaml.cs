//**********************************************************
//* DomainName: Common Models
//* FileName:   QuarterlyEmploymentRecordView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The QuarterlyEmploymentRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuarterlyEmploymentRecordView : ContentPage
    {
        /// <summary>
        /// Inject the IQuarterlyEmploymentRecord View Model as the data context for the view
        /// </summary>
        public QuarterlyEmploymentRecordView(Interfaces.IQuarterlyEmploymentRecord vm)
        {
            BindingContext  = vm;
        }
    }
}

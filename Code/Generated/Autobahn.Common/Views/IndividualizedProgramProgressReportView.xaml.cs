//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressReportView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramProgressReportView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramProgressReportView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramProgressReportViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramProgressReportView(IndividualizedProgramProgressReportViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

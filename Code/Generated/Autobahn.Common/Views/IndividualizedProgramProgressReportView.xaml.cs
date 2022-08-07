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
        /// Inject the IIndividualizedProgramProgressReportViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramProgressReportView(IIndividualizedProgramProgressReportViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

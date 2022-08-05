//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressReportPlanView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramProgressReportPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramProgressReportPlanViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramProgressReportPlanView(IndividualizedProgramProgressReportPlanViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressReportPlanView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramProgressReportPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramProgressReportPlan View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramProgressReportPlanView(Interfaces.IIndividualizedProgramProgressReportPlan vm)
        {
            BindingContext  = vm;
        }
    }
}

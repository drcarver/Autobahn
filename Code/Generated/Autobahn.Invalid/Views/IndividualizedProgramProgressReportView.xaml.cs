//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressReportView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IndividualizedProgramProgressReportView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramProgressReportView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramProgressReport View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramProgressReportView(Interfaces.IIndividualizedProgramProgressReport vm)
        {
            BindingContext  = vm;
        }
    }
}

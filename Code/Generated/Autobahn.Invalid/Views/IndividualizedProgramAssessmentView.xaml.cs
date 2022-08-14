//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAssessmentView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IndividualizedProgramAssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramAssessment View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramAssessmentView(Interfaces.IIndividualizedProgramAssessment vm)
        {
            BindingContext  = vm;
        }
    }
}

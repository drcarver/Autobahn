//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentView.cs
//**********************************************************

namespace Autobahn.Common.Views
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

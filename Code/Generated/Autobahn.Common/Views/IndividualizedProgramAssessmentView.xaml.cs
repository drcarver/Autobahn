//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAssessmentView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramAssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramAssessmentViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAssessmentView(IIndividualizedProgramAssessmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

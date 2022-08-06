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
        /// Inject the IndividualizedProgramAssessmentViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAssessmentView(IndividualizedProgramAssessmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

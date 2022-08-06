//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAssessmentAccommodationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAssessmentAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramAssessmentAccommodationViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAssessmentAccommodationView(IndividualizedProgramAssessmentAccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

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
        /// Inject the IIndividualizedProgramAssessmentAccommodationViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAssessmentAccommodationView(IIndividualizedProgramAssessmentAccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

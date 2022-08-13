//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAssessmentAccommodationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAssessmentAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramAssessmentAccommodation View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramAssessmentAccommodationView(Interfaces.IIndividualizedProgramAssessmentAccommodation vm)
        {
            BindingContext  = vm;
        }
    }
}

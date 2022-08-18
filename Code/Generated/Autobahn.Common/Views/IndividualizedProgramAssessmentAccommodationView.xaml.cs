//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentAccommodationView.cs
//**********************************************************

namespace Autobahn.Common.Views
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

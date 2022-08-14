//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAccommodationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAccommodation View Model as the data context for the view
        /// </summary>
        public AssessmentAccommodationView(Interfaces.IAssessmentAccommodation vm)
        {
            BindingContext  = vm;
        }
    }
}

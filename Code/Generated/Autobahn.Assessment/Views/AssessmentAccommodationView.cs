//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAccommodationView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentAccommodationViewModel as the data context for the view
        /// </summary>
        public AssessmentAccommodationView(AssessmentAccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

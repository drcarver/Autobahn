//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAccommodationSubjectView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubjectView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAccommodationSubjectView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramAccommodationSubjectViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAccommodationSubjectView(IndividualizedProgramAccommodationSubjectViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAccommodationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramAccommodationViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAccommodationView(IndividualizedProgramAccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

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
        /// Inject the IIndividualizedProgramAccommodationViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAccommodationView(IIndividualizedProgramAccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

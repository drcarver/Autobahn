//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAccommodationView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IndividualizedProgramAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramAccommodation View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramAccommodationView(Interfaces.IIndividualizedProgramAccommodation vm)
        {
            BindingContext  = vm;
        }
    }
}

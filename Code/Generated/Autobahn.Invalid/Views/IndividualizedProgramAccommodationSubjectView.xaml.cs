//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAccommodationSubjectView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubjectView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAccommodationSubjectView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramAccommodationSubject View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramAccommodationSubjectView(Interfaces.IIndividualizedProgramAccommodationSubject vm)
        {
            BindingContext  = vm;
        }
    }
}

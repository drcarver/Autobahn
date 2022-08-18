//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationSubjectView.cs
//**********************************************************

namespace Autobahn.Common.Views
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

//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramEligibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramEligibilityView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramEligibility View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramEligibilityView(Interfaces.IIndividualizedProgramEligibility vm)
        {
            BindingContext  = vm;
        }
    }
}

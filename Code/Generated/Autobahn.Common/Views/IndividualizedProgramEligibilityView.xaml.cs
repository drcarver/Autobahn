//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramEligibilityView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramEligibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramEligibilityView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramEligibilityViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramEligibilityView(IndividualizedProgramEligibilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

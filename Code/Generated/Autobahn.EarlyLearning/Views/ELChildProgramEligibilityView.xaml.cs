//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildProgramEligibilityView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildProgramEligibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildProgramEligibilityView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildProgramEligibilityViewModel as the data context for the view
        /// </summary>
        public ELChildProgramEligibilityView(IELChildProgramEligibilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

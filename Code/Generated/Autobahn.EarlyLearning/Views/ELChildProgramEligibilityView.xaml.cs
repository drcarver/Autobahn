//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildProgramEligibilityView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildProgramEligibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildProgramEligibilityView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildProgramEligibility View Model as the data context for the view
        /// </summary>
        public ELChildProgramEligibilityView(Interfaces.IELChildProgramEligibility vm)
        {
            BindingContext  = vm;
        }
    }
}

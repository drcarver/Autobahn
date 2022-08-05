//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildTransitionPlanView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildTransitionPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildTransitionPlanView : ContentPage
    {
        /// <summary>
        /// Inject the ELChildTransitionPlanViewModel as the data context for the view
        /// </summary>
        public ELChildTransitionPlanView(ELChildTransitionPlanViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

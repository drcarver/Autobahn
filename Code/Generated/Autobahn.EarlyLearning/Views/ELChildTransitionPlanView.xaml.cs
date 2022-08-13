//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildTransitionPlanView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildTransitionPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildTransitionPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildTransitionPlan View Model as the data context for the view
        /// </summary>
        public ELChildTransitionPlanView(Interfaces.IELChildTransitionPlan vm)
        {
            BindingContext  = vm;
        }
    }
}

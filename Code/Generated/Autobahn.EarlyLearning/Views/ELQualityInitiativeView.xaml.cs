//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityInitiativeView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELQualityInitiativeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELQualityInitiativeView : ContentPage
    {
        /// <summary>
        /// Inject the IELQualityInitiative View Model as the data context for the view
        /// </summary>
        public ELQualityInitiativeView(Interfaces.IELQualityInitiative vm)
        {
            BindingContext  = vm;
        }
    }
}

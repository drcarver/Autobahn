//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELQualityInitiativeView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELQualityInitiativeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELQualityInitiativeView : ContentPage
    {
        /// <summary>
        /// Inject the IELQualityInitiativeViewModel as the data context for the view
        /// </summary>
        public ELQualityInitiativeView(IELQualityInitiativeViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

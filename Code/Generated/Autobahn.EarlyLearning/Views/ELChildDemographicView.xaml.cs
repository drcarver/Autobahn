//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildDemographicView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildDemographicView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildDemographicView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildDemographicViewModel as the data context for the view
        /// </summary>
        public ELChildDemographicView(IELChildDemographicViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

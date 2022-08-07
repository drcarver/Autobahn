//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildServicesApplicationView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildServicesApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildServicesApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildServicesApplicationViewModel as the data context for the view
        /// </summary>
        public ELChildServicesApplicationView(IELChildServicesApplicationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the ELOrganizationViewModel as the data context for the view
        /// </summary>
        public ELOrganizationView(ELOrganizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

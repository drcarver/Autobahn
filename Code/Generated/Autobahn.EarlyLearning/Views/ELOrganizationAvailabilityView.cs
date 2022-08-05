//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationAvailabilityView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationAvailabilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationAvailabilityView : ContentPage
    {
        /// <summary>
        /// Inject the ELOrganizationAvailabilityViewModel as the data context for the view
        /// </summary>
        public ELOrganizationAvailabilityView(ELOrganizationAvailabilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

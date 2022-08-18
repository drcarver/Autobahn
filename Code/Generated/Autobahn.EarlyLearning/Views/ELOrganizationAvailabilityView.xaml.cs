//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationAvailabilityView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationAvailabilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationAvailabilityView : ContentPage
    {
        /// <summary>
        /// Inject the IELOrganizationAvailability View Model as the data context for the view
        /// </summary>
        public ELOrganizationAvailabilityView(Interfaces.IELOrganizationAvailability vm)
        {
            BindingContext  = vm;
        }
    }
}

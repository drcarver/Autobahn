//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELFacilityLicensingView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELFacilityLicensingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELFacilityLicensingView : ContentPage
    {
        /// <summary>
        /// Inject the ELFacilityLicensingViewModel as the data context for the view
        /// </summary>
        public ELFacilityLicensingView(ELFacilityLicensingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

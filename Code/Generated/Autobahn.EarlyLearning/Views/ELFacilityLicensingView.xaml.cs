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
        /// Inject the IELFacilityLicensingViewModel as the data context for the view
        /// </summary>
        public ELFacilityLicensingView(IELFacilityLicensingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

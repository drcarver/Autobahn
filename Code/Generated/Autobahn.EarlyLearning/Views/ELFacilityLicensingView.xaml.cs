//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELFacilityLicensingView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELFacilityLicensingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELFacilityLicensingView : ContentPage
    {
        /// <summary>
        /// Inject the IELFacilityLicensing View Model as the data context for the view
        /// </summary>
        public ELFacilityLicensingView(Interfaces.IELFacilityLicensing vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationMonitoringView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationMonitoringView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationMonitoringView : ContentPage
    {
        /// <summary>
        /// Inject the IELOrganizationMonitoring View Model as the data context for the view
        /// </summary>
        public ELOrganizationMonitoringView(Interfaces.IELOrganizationMonitoring vm)
        {
            BindingContext  = vm;
        }
    }
}

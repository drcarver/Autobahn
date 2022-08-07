//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationMonitoringView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationMonitoringView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationMonitoringView : ContentPage
    {
        /// <summary>
        /// Inject the IELOrganizationMonitoringViewModel as the data context for the view
        /// </summary>
        public ELOrganizationMonitoringView(IELOrganizationMonitoringViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

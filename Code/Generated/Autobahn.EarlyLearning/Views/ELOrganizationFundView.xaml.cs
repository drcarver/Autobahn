//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationFundView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationFundView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationFundView : ContentPage
    {
        /// <summary>
        /// Inject the IELOrganizationFundViewModel as the data context for the view
        /// </summary>
        public ELOrganizationFundView(IELOrganizationFundViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

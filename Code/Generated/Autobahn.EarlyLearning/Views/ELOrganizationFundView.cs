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
        /// Inject the ELOrganizationFundViewModel as the data context for the view
        /// </summary>
        public ELOrganizationFundView(ELOrganizationFundViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

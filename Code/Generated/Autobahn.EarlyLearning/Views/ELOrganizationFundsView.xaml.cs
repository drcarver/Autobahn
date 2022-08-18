//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundsView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationFundsView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationFundsView : ContentPage
    {
        /// <summary>
        /// Inject the IELOrganizationFunds View Model as the data context for the view
        /// </summary>
        public ELOrganizationFundsView(Interfaces.IELOrganizationFunds vm)
        {
            BindingContext  = vm;
        }
    }
}

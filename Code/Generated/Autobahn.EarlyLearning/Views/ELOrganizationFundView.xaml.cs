//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationFundView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationFundView : ContentPage
    {
        /// <summary>
        /// Inject the IELOrganizationFund View Model as the data context for the view
        /// </summary>
        public ELOrganizationFundView(Interfaces.IELOrganizationFund vm)
        {
            BindingContext  = vm;
        }
    }
}

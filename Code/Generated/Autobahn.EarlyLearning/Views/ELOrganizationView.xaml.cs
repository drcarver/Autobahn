//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IELOrganization View Model as the data context for the view
        /// </summary>
        public ELOrganizationView(Interfaces.IELOrganization vm)
        {
            BindingContext  = vm;
        }
    }
}

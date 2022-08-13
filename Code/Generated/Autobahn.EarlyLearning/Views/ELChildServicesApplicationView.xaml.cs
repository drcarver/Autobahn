//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServicesApplicationView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildServicesApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildServicesApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildServicesApplication View Model as the data context for the view
        /// </summary>
        public ELChildServicesApplicationView(Interfaces.IELChildServicesApplication vm)
        {
            BindingContext  = vm;
        }
    }
}

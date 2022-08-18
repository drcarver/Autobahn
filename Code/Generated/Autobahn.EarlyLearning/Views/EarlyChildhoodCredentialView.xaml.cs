//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The EarlyChildhoodCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EarlyChildhoodCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the IEarlyChildhoodCredential View Model as the data context for the view
        /// </summary>
        public EarlyChildhoodCredentialView(Interfaces.IEarlyChildhoodCredential vm)
        {
            BindingContext  = vm;
        }
    }
}

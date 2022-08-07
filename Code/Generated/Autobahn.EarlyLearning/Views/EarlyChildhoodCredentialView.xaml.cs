//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   EarlyChildhoodCredentialView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The EarlyChildhoodCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EarlyChildhoodCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the IEarlyChildhoodCredentialViewModel as the data context for the view
        /// </summary>
        public EarlyChildhoodCredentialView(IEarlyChildhoodCredentialViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

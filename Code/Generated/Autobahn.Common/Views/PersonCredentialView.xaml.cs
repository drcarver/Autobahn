//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCredentialView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonCredentialViewModel as the data context for the view
        /// </summary>
        public PersonCredentialView(IPersonCredentialViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

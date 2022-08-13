//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonCredential View Model as the data context for the view
        /// </summary>
        public PersonCredentialView(Interfaces.IPersonCredential vm)
        {
            BindingContext  = vm;
        }
    }
}

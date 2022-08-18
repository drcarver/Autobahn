//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonTelephoneView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonTelephoneView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonTelephoneView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonTelephone View Model as the data context for the view
        /// </summary>
        public PersonTelephoneView(Interfaces.IPersonTelephone vm)
        {
            BindingContext  = vm;
        }
    }
}

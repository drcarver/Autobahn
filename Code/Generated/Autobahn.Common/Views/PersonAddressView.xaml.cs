//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonAddressView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAddressView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonAddress View Model as the data context for the view
        /// </summary>
        public PersonAddressView(Interfaces.IPersonAddress vm)
        {
            BindingContext  = vm;
        }
    }
}

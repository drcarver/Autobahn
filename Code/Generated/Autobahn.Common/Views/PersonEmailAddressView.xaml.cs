//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonEmailAddressView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonEmailAddressView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonEmailAddress View Model as the data context for the view
        /// </summary>
        public PersonEmailAddressView(Interfaces.IPersonEmailAddress vm)
        {
            BindingContext  = vm;
        }
    }
}

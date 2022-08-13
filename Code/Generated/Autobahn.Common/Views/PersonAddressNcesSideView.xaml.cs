//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonAddressNcesSideView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAddressNcesSideView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonAddressNcesSide View Model as the data context for the view
        /// </summary>
        public PersonAddressNcesSideView(Interfaces.IPersonAddressNcesSide vm)
        {
            BindingContext  = vm;
        }
    }
}

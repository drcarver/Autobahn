//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonTelephoneView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonTelephoneView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonTelephoneView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonTelephoneViewModel as the data context for the view
        /// </summary>
        public PersonTelephoneView(IPersonTelephoneViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

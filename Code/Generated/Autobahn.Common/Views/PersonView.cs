//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonView : ContentPage
    {
        /// <summary>
        /// Inject the PersonViewModel as the data context for the view
        /// </summary>
        public PersonView(PersonViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

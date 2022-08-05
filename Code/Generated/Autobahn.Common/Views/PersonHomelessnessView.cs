//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHomelessnessView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHomelessnessView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHomelessnessView : ContentPage
    {
        /// <summary>
        /// Inject the PersonHomelessnessViewModel as the data context for the view
        /// </summary>
        public PersonHomelessnessView(PersonHomelessnessViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
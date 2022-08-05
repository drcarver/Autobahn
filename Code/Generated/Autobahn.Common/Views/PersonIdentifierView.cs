//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonIdentifierView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonIdentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonIdentifierView : ContentPage
    {
        /// <summary>
        /// Inject the PersonIdentifierViewModel as the data context for the view
        /// </summary>
        public PersonIdentifierView(PersonIdentifierViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

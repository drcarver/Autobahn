//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMasterView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonMasterView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonMasterView : ContentPage
    {
        /// <summary>
        /// Inject the PersonMasterViewModel as the data context for the view
        /// </summary>
        public PersonMasterView(PersonMasterViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

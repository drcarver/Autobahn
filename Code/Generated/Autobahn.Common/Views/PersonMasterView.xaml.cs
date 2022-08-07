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
        /// Inject the IPersonMasterViewModel as the data context for the view
        /// </summary>
        public PersonMasterView(IPersonMasterViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

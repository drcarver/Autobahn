//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHealthView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHealthView : ContentPage
    {
        /// <summary>
        /// Inject the PersonHealthViewModel as the data context for the view
        /// </summary>
        public PersonHealthView(PersonHealthViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonLanguageView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonLanguageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonLanguageView : ContentPage
    {
        /// <summary>
        /// Inject the PersonLanguageViewModel as the data context for the view
        /// </summary>
        public PersonLanguageView(PersonLanguageViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
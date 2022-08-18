//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonLanguageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonLanguageView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonLanguage View Model as the data context for the view
        /// </summary>
        public PersonLanguageView(Interfaces.IPersonLanguage vm)
        {
            BindingContext  = vm;
        }
    }
}

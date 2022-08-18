//**********************************************************
//* DomainName: Common Models
//* FileName:   KeywordTranslationLanguageTypeView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The KeywordTranslationLanguageTypeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeywordTranslationLanguageTypeView : ContentPage
    {
        /// <summary>
        /// Inject the IKeywordTranslationLanguageType View Model as the data context for the view
        /// </summary>
        public KeywordTranslationLanguageTypeView(Interfaces.IKeywordTranslationLanguageType vm)
        {
            BindingContext  = vm;
        }
    }
}

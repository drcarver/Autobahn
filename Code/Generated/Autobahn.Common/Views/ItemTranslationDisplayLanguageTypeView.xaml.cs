//**********************************************************
//* DomainName: Common Models
//* FileName:   ItemTranslationDisplayLanguageTypeView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ItemTranslationDisplayLanguageTypeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemTranslationDisplayLanguageTypeView : ContentPage
    {
        /// <summary>
        /// Inject the IItemTranslationDisplayLanguageType View Model as the data context for the view
        /// </summary>
        public ItemTranslationDisplayLanguageTypeView(Interfaces.IItemTranslationDisplayLanguageType vm)
        {
            BindingContext  = vm;
        }
    }
}

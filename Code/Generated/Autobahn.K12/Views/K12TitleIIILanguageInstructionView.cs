//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12TitleIIILanguageInstructionView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12TitleIIILanguageInstructionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12TitleIIILanguageInstructionView : ContentPage
    {
        /// <summary>
        /// Inject the K12TitleIIILanguageInstructionViewModel as the data context for the view
        /// </summary>
        public K12TitleIIILanguageInstructionView(K12TitleIIILanguageInstructionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

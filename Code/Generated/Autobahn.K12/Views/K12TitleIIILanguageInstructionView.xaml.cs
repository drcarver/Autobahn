//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12TitleIIILanguageInstructionView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12TitleIIILanguageInstructionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12TitleIIILanguageInstructionView : ContentPage
    {
        /// <summary>
        /// Inject the IK12TitleIIILanguageInstruction View Model as the data context for the view
        /// </summary>
        public K12TitleIIILanguageInstructionView(Interfaces.IK12TitleIIILanguageInstruction vm)
        {
            BindingContext  = vm;
        }
    }
}

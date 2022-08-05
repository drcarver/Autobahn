//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CoreKnowledgeAreaView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CoreKnowledgeAreaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoreKnowledgeAreaView : ContentPage
    {
        /// <summary>
        /// Inject the CoreKnowledgeAreaViewModel as the data context for the view
        /// </summary>
        public CoreKnowledgeAreaView(CoreKnowledgeAreaViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

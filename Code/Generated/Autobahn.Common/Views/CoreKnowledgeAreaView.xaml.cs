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
        /// Inject the ICoreKnowledgeAreaViewModel as the data context for the view
        /// </summary>
        public CoreKnowledgeAreaView(ICoreKnowledgeAreaViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

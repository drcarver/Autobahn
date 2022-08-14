//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CoreKnowledgeAreaView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The CoreKnowledgeAreaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoreKnowledgeAreaView : ContentPage
    {
        /// <summary>
        /// Inject the ICoreKnowledgeArea View Model as the data context for the view
        /// </summary>
        public CoreKnowledgeAreaView(Interfaces.ICoreKnowledgeArea vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Competencies
//* FileName:   CoreKnowledgeAreaView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
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

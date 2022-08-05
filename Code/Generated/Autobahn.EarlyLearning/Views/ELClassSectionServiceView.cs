//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELClassSectionServiceView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELClassSectionServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELClassSectionServiceView : ContentPage
    {
        /// <summary>
        /// Inject the ELClassSectionServiceViewModel as the data context for the view
        /// </summary>
        public ELClassSectionServiceView(ELClassSectionServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

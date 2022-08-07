//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELClassSectionView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELClassSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELClassSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IELClassSectionViewModel as the data context for the view
        /// </summary>
        public ELClassSectionView(IELClassSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELClassSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELClassSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IELClassSection View Model as the data context for the view
        /// </summary>
        public ELClassSectionView(Interfaces.IELClassSection vm)
        {
            BindingContext  = vm;
        }
    }
}

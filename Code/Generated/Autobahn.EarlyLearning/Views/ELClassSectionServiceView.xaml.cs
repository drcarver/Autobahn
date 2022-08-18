//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionServiceView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELClassSectionServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELClassSectionServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IELClassSectionService View Model as the data context for the view
        /// </summary>
        public ELClassSectionServiceView(Interfaces.IELClassSectionService vm)
        {
            BindingContext  = vm;
        }
    }
}
